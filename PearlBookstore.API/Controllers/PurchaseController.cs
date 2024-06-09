using Microsoft.AspNetCore.Mvc;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;
using PearlBookstore.API.Services;
using PearlBookstore.Shared.RequestsResponses.Requests;
using PearlBookstore.Shared.RequestsResponses.Responses;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseController(Bucket bucket, AppDbContext context, CurrentEmployee employee) : ControllerBase
    {
        [HttpPost("AddItemToBucket")]
        public async Task<DefaultResponse> AddItemToBucket(AddItemToBucketRequest request)
        {
            string prefix = "Nie udało się dodać publikacji do koszyka zakupu.";
            DefaultResponse response = new();

            var item = context.Items.Where(i => i.Id == request.ItemId).FirstOrDefault();

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

        [HttpPost("RemoveItemFromBucket/{ItemId}")]
        public async Task<DefaultResponse> RemoveItemFromBucket(int ItemId)
        {
            string prefix = "Nie udało się usunąć publikacji z koszyka zakupu.";
            DefaultResponse response = new();
            var item = context.Items.Where(i => i.Id == ItemId).FirstOrDefault();

            if (item == null)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Publikacja nie znajduje się w systemie.";
                return await Task.FromResult(response);
            }

            int removed = bucket.Items.RemoveAll(x => x.ItemId == ItemId);
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
                sum += item.Price;
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

        [HttpGet("Accept")]
        public async Task<DefaultResponse> Accept()
        {
            string prefix = "Nie udało się zaakceptować zakupu.";
            DefaultResponse response = new();
            if (bucket.Items.Count == 0)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Koszyk zakupu jest pusty.";
                return await Task.FromResult(response);
            }

            using var transaction = context.Database.BeginTransaction();

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

                DateTime current = DateTime.Now;
                DateOnly purchaseDate = new(current.Year, current.Month, current.Day);
                string paymentID = $"{purchaseDate.Year}_{purchaseDate.Month}_{purchaseDate.Day}_{bucket.Items[0].EmployeeId}_{new Guid()}";

                var purchase = new Purchase
                {
                    Item = item,
                    ItemId = item.Id,
                    Counter = 1,
                    EmployeeId = employee.Current.Id,
                    Employee = employee.Current,
                    Date = purchaseDate,
                    PaymentId = paymentID
                };
                item.Counter--;

            }

            if (context.SaveChanges() == bucket.Items.Count)
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
                response.Message = $"{prefix} Wystąpił błąd przy zatwierdzaniu zakupu. Skontaktuj się z administratorem.";
                return await Task.FromResult(response);
            }
        }

    }
}
