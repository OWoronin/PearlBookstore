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

    public class ReturnController(AppDbContext context, ReturnBucket bucket, CurrentEmployee employee) : ControllerBase
    {
        [HttpPost("AddToReturnBucket")]
        public async Task<DefaultResponse> AddToReturnBucket(AddItemToBucketRequest request)
        {
            string prefix = "Nie udało się dodać publikacji do koszyka zwrotu.";
            DefaultResponse resposne = new();
            var item = await context.Items.Where(i => i.Id == request.ItemId && i.Types.Select(t => t.TypeId).Contains(request.TypeId)).FirstOrDefaultAsync();

            if (item != null)
            {
                resposne.IsSuccess = true;
                bucket.Items.Add(request);
                return await Task.FromResult(resposne);
            }
            else
            {
                resposne.IsSuccess = false;
                resposne.Message = $"{prefix} Publikacja nie znajduje się w systemie.";
                return await Task.FromResult(resposne);
            }

        }

        [HttpPost("ModifyPriceOfItem")]

        public async Task<DefaultResponse> ModifyPriceOfItem(ModifyPriceAndCountOfItemInBucketRequest request)
        {
            string prefix = "Nie udało się zmienić ceny publikacji w zwrocie.";
            DefaultResponse resposne = new();
            var item = context.Items.Where(i => i.Id == request.ItemId && i.Types.Select(t => t.TypeId).Contains(request.TypeId)).FirstOrDefault();
            if (item != null)
            {
                var itemInBucket = bucket.Items.Where(i => i.ItemId == request.ItemId && i.TypeId == request.TypeId).FirstOrDefault();
                if (itemInBucket != null)
                {
                    resposne.IsSuccess = true;
                    itemInBucket.Price = request.Price;
                    itemInBucket.ActionCounter = request.ActionCounter;
                }
                else
                {
                    resposne.IsSuccess = false;
                    resposne.Message = $"{prefix} Publikacja nie znajduje się w koszyku.";
                }

            }
            else
            {
                resposne.IsSuccess = false;
                resposne.Message = $"{prefix} Podana publikacja nie znajduje się w koszyku zwrotu.";
            }
            return await Task.FromResult(resposne);
        }

        [HttpPost("RemoveItemFromBucket")]
        public async Task<DefaultResponse> RemoveItemFromBucket(RemoveFromBucketRequest request)
        {
            string prefix = "Nie udało się usunąć publikacji z koszyka zwrotu.";
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

        [HttpGet("PriceOfAllInReturnBucket")]
        public async Task<PriceOfBucketReponse> PriceOfAllInReturnBucket()
        {
            string prefix = "Nie udało się pudsumować kwoty koszyka zwrotu.";
            PriceOfBucketReponse response = new();
            decimal sum = 0;
            for (int i = 0; i < bucket.Items.Count; i++)
            {
                var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId && it.Types.Select(t => t.TypeId).Contains(bucket.Items[i].TypeId)).FirstOrDefault();
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

        [HttpGet("AcceptReturnBucket/{purchaseID}")]
        public async Task<DefaultResponse> AcceptReturnBucket(int purchaseID)
        {
            string prefix = "Nie udało się zaakceptować zwrotu.";
            DefaultResponse response = new();
            if (bucket.Items.Count == 0)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Koszyk zwrotu jest pusty.";
                return await Task.FromResult(response);
            }

            var purchase = context.Purchases.Where(p => p.Id == purchaseID).FirstOrDefault();

            if (purchase == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Podany zakup nie istnieje w systemie.";
                return await Task.FromResult(response);
            }

            using var transaction = context.Database.BeginTransaction();

            DateTime current = DateTime.Now;
            DateOnly returnDate = new(current.Year, current.Month, current.Day);

            var sum = bucket.Items.Sum(item => item.Price * item.ActionCounter);

            var returnObj = new Return
            {
                Date = returnDate,
                Employee = employee.Current,
                EmployeeID = bucket.Items[0].EmployeeId,
                TotalReturn = sum,
                Purchase = purchase,
                PurchaseID = purchaseID,
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
                var itemType = context.ItemsTypes.Where(it => it.ItemId == bucket.Items[i].ItemId && it.TypeId == bucket.Items[i].TypeId).FirstOrDefault();

                if (itemType == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Publikacja o danym typie nie istenieje w systemie.";
                    await transaction.RollbackAsync();
                    return await Task.FromResult(response);
                }
                itemType.Counter += bucket.Items[i].ActionCounter;

                var returnItem = new ItemReturn
                {
                    Id = bucket.Items[i].ItemId,
                    Counter = bucket.Items[i].ActionCounter,
                    Price = bucket.Items[i].Price,
                    Return = returnObj,
                    ReturnID = returnObj.Id,
                    TypeId = bucket.Items[i].TypeId,
                    Type = itemType.Type,
                    Item = item,
                    ItemId = bucket.Items[i].ItemId,
                };

                context.ItemReturns.Add(returnItem);
            }

            if (context.SaveChanges() == bucket.Items.Count * 2 + 1)
            {
                await transaction.CommitAsync();
                bucket.Items.Clear();
                response.IsSuccess = true;
                return await Task.FromResult(response);
            }
            else
            {
                await transaction.RollbackAsync();
                response.IsSuccess = false;
                response.Message = $"{prefix} Wystąpił błąd przy zatwierdzaniu zwrotu. Skontaktuj się z administratorem.";
                return await Task.FromResult(response);
            }
        }
    }
}
