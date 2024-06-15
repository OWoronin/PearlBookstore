using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;
using PearlBookstore.API.Services;
using PearlBookstore.Shared.RequestsResponses.Requests;
using PearlBookstore.Shared.RequestsResponses.Responses;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseController(PurchaseBucket bucket, AppDbContext context, CurrentEmployee employee) : ControllerBase
    {
        [HttpPost("AddItemToBucket")]
        public async Task<DefaultResponse> AddItemToBucket(AddItemToBucketRequest request)
        {
            string prefix = "Nie udało się dodać publikacji do koszyka zakupu.";
            DefaultResponse response = new();

            var item = await context.Items.Where(i => i.Id == request.ItemId && i.Types.Select(t => t.TypeId).Contains(request.TypeId)).FirstOrDefaultAsync();

            if (item == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Publikacja nie znajduje się w systemie.";
                return await Task.FromResult(response);
            }

            bucket.Items.Add(request);
            response.IsSuccess = true;
            return await Task.FromResult(response);
        }

        [HttpPost("RemoveItemFromBucket")]
        public async Task<DefaultResponse> RemoveItemFromBucket(RemoveFromBucketRequest request)
        {
            string prefix = "Nie udało się usunąć publikacji z koszyka zakupu.";
            DefaultResponse response = new();
            var item = context.Items.Where(i => i.Id == request.ItemId && i.Types.Select(t => t.TypeId).Contains(request.TypeId)).FirstOrDefault();

            if (item == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Publikacja nie znajduje się w systemie.";
                return await Task.FromResult(response);
            }

            int removed = bucket.Items.RemoveAll(x => x.ItemId == request.ItemId && x.TypeId == request.TypeId);
            if (removed == 0)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Publikacja nie znajduje się w koszyku.";
                return await Task.FromResult(response);
            }
            else
            {
                response.IsSuccess = true;
                return await Task.FromResult(response);
            }
        }
        [HttpGet("PriceOfAllInBucket")]
        public async Task<PriceOfBucketReponse> PriceOfAllInBucket()
        {
            string prefix = "Nie udało się pudsumować kwoty koszyka zakupu.";
            PriceOfBucketReponse response = new();
            decimal sum = 0;
            for (int i = 0; i < bucket.Items.Count; i++)
            {
                var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId).FirstOrDefault();
                if (item == null)
                {
                    response.IsSuccess = false;
                    response.Message = $"{prefix} Publikacja w koszyku nie znajduje się w systemie.";
                    return await Task.FromResult(response);
                }
                sum += bucket.Items[i].Price * bucket.Items[i].ActionCounter;
            }
            response.IsSuccess = true;
            response.Price = sum;
            return await Task.FromResult(response);

        }

        [HttpPost("ClearBucket")]
        public Task ClearBucket()
        {
            bucket.Items.Clear();
            return Task.CompletedTask;

        }

        [HttpPost("ModifyCount")]
        public async Task<DefaultResponse> ModifyCount(ModifyCountOfItemInBucketRequest request)
        {
            string prefix = "Nie udało się zmodyfikować ilości publikacji w zakupie.";
            var response = new DefaultResponse();
            var item = context.Items.Where(i => i.Id == request.ItemId && i.Types.Select(t => t.TypeId).Contains(request.TypeId)).FirstOrDefault();

            if (item == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Publikacja nie znajduje się w systemie.";
                return await Task.FromResult(response);
            }

            var itemInBucket = bucket.Items.Where(x => x.ItemId == request.ItemId && x.TypeId == request.TypeId).FirstOrDefault();

            if (itemInBucket == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Dana publikacja nie znajduje się w koszyku zakupu.";
                return await Task.FromResult(response);
            }

            itemInBucket.ActionCounter = request.ActionCounter;

            response.IsSuccess = true;

            return await Task.FromResult(response);
        }

        [HttpGet("Accept")]
        public async Task<AcceptResponse> Accept()
        {
            string prefix = "Nie udało się zaakceptować zakupu.";
            AcceptResponse response = new();
            if (bucket.Items.Count == 0)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Koszyk zakupu jest pusty.";
                return await Task.FromResult(response);
            }

            using var transaction = context.Database.BeginTransaction();

            var sum = bucket.Items.Sum(it => it.Price * it.ActionCounter);

            DateTime current = DateTime.Now;
            DateOnly purchaseDate = new(current.Year, current.Month, current.Day);
            Guid newGuid = Guid.NewGuid();
            string guidString = newGuid.ToString("N");
            string firstEightChars = guidString[..8];

            string purchaseID = $"{purchaseDate.Year}_{purchaseDate.Month}_{purchaseDate.Day}_{bucket.Items[0].EmployeeId}_{firstEightChars}";

            var purchase = new Purchase
            {
                EmployeeId = bucket.Items[0].EmployeeId,
                Employee = employee.Current,
                Date = purchaseDate,
                PurchaseID = purchaseID,
                TotalPrice = sum
            };

            context.Purchases.Add(purchase);

            for (int i = 0; i < bucket.Items.Count; i++)
            {
                var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId).FirstOrDefault();

                if (item == null)
                {
                    response.IsSuccess = false;
                    response.Message = $"{prefix} Publikacja w koszyku zakupu nie znajduje się w systemie.";
                    await transaction.RollbackAsync();
                    return await Task.FromResult(response);
                }

                var itemType = await context.ItemsTypes.Where(it => it.ItemId == item.Id && it.TypeId == bucket.Items[i].TypeId).FirstOrDefaultAsync();
                if (itemType == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Publikacja o danym typie nie istnieje w systemie.";
                    await transaction.RollbackAsync();
                    return await Task.FromResult(response);
                }

                itemType.Counter -= bucket.Items[i].ActionCounter;

                var itemPurchase = new ItemPurchase
                {
                    Counter = bucket.Items[i].ActionCounter,
                    ItemId = bucket.Items[i].ItemId,
                    Item = item,
                    TypeId = bucket.Items[i].TypeId,
                    Type = itemType.Type,
                    Purchase = purchase,
                    PurchaseID = purchase.Id
                };

                context.ItemPurchases.Add(itemPurchase);

            }

            if (context.SaveChanges() == bucket.Items.Count * 2 + 1)
            {
                await transaction.CommitAsync();
                bucket.Items.Clear();
                response.IsSuccess = true;
                response.Price = sum;
                response.Date = purchaseDate;
                response.Evidence = purchaseID;
                return await Task.FromResult(response);
            }
            else
            {
                await transaction.RollbackAsync();
                response.IsSuccess = false;
                response.Message = $"{prefix} Wystąpił błąd przy zatwierdzaniu zakupu. Skontaktuj się z administratorem.";
                return await Task.FromResult(response);
            }
        }

    }
}
