using Microsoft.AspNetCore.Mvc;
using PearlBookstore.API.DB;
using PearlBookstore.API.Services;
using PearlBookstore.Shared.RequestsResponses.Requests;
using PearlBookstore.Shared.RequestsResponses.Responses;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ReturnController(AppDbContext context, ReturnBucket bucket) : ControllerBase
    {
        [HttpPost("AddToReturnBucket")]
        public async Task<DefaultResponse> AddToReturnBucket(AddItemToBucketRequest request)
        {
            string prefix = "Nie udało się dodać publikacji do koszyka zwrotu.";
            DefaultResponse resposne = new();
            var item = context.Items.Where(i => i.Id == request.ItemId).FirstOrDefault();
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

        public async Task<DefaultResponse> ModifyPriceOfItem(ModifyPriceOfItemInBucketRequest request)
        {
            string prefix = "Nie udało się zmienić ceny publikacji w zwrocie.";
            DefaultResponse resposne = new();
            var item = bucket.Items.Where(i => i.ItemId == request.ItemId).FirstOrDefault();
            if (item != null)
            {
                resposne.IsSuccess = true;
                item.Price = request.Price;
            }
            else
            {
                resposne.IsSuccess = false;
                resposne.Message = $"{prefix} Podana publikacja nie znajduje się w koszyku zwrotu.";
            }
            return await Task.FromResult(resposne);
        }

        [HttpPost("RemoveItemFromBucket/{ItemId}")]
        public async Task<DefaultResponse> RemoveItemFromBucket(int ItemId)
        {
            string prefix = "Nie udało się usunąć publikacji z koszyka zwrotu.";
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

        [HttpGet("PriceOfAllInReturnBucket")]
        public async Task<PriceOfBucketReponse> PriceOfAllInReturnBucket()
        {
            string prefix = "Nie udało się pudsumować kwoty koszyka zwrotu.";
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
                sum += bucket.Items[i].Price;
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

        [HttpGet("AcceptReturnBucket")]
        public async Task<DefaultResponse> AcceptReturnBucket()
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
                var itemType = context.ItemsTypes.Where(it => it.ItemId == bucket.Items[i].ItemId && it.TypeId == bucket.Items[i].TypeId).FirstOrDefault();

                if (itemType == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Publikacja o danym typie nie istenieje w systemie.";
                    await transaction.RollbackAsync();
                    return await Task.FromResult(response);
                }
                itemType.Counter++;
            }

            if (context.SaveChanges() == bucket.Items.Count)
            {
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
