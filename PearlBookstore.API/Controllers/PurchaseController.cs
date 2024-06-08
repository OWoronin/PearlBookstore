using Microsoft.AspNetCore.Mvc;
using PearlBookstore.API.DB;
using PearlBookstore.API.Services;
using PearlBookstore.Shared.RequestsResponses;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseController(Bucket bucket, AppDbContext context) : ControllerBase
    {
        [HttpPost("AddItemToBucket")]
        public async Task<bool> AddItemToBucket(AddItemToBucketRequest request)
        {

            var item = context.Items.Where(i => i.Id == request.ItemId).FirstOrDefault();

            if (item == null)
            {
                return await Task.FromResult(false);
            }


            bucket.Items.Add(request);
            return await Task.FromResult(true);
        }

        [HttpPost("RemoveItemFromBucket")]
        public async Task<bool> RemoveItemFromBucket(int ItemId)
        {
            var item = context.Items.Where(i => i.Id == ItemId).FirstOrDefault();

            if (item == null)
            {
                return await Task.FromResult(false);
            }

            int removed = bucket.Items.RemoveAll(x => x.ItemId == ItemId);
            if (removed == 0)
            {
                return await Task.FromResult(false);
            }
            else
            {
                return await Task.FromResult(true);
            }
        }
        [HttpGet("PriceOfAllInBucket")]
        public async Task<decimal> PriceOfAllInBucket()
        {
            decimal sum = 0;
            for (int i = 0; i < bucket.Items.Count; i++)
            {
                var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId).FirstOrDefault();
                sum += item.Price;
            }
            return await Task.FromResult(sum);

        }

        [HttpGet("Accept")]
        public async Task<bool> Accept()
        {
            for (int i = 0; i < bucket.Items.Count; i++)
            {
                var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId).FirstOrDefault();
                item.Counter--;

            }

            if (context.SaveChanges() == bucket.Items.Count)
            {
                bucket.Items.Clear();
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }



        }

    }
}
