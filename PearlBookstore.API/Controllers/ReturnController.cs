using Microsoft.AspNetCore.Mvc;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;
using PearlBookstore.API.Services;
using PearlBookstore.Shared;
using PearlBookstore.Shared.RequestsResponses.Requests;

namespace PearlBookstore.API.Controllers
{
    [ApiController]
	[Route("api/[controller]")]

	public class ReturnController(AppDbContext context, Bucket bucket) : ControllerBase
	{
		[HttpPost("AddToReturnBucket")]
		public async Task<bool> AddToReturnBucket(AddItemToBucketRequest request)
		{
			var item = context.Items.Where(i => i.Id == request.ItemId).FirstOrDefault();
			if (item != null)
			{
				bucket.Items.Add(request);
				return await Task.FromResult(true);
			}
			else
			{
				return await Task.FromResult(false);
			}

		}

		[HttpPost("ModifyPriceOfItem")]

		public async Task<bool> ModifyPriceOfItem(ModifyPriceOfItemInBucketRequest request)
		{

			var item = bucket.Items.Where(i => i.ItemId == request.ItemId).FirstOrDefault();
			item.Price = request.Price;
			return await Task.FromResult(true);
		}

		[HttpGet("PriceOfAllInReturnBucket")]
		public async Task<decimal> PriceOfAllInReturnBucket()
		{
			decimal sum = 0;
			for (int i = 0; i < bucket.Items.Count; i++)
			{

				sum += bucket.Items[i].Price;
			}
			return await Task.FromResult(sum);

		}

		[HttpGet("AcceptReturnBucket")]
		public async Task<bool> AcceptReturnBucket()
		{
			for (int i = 0; i < bucket.Items.Count; i++)
			{
				var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId).FirstOrDefault();
				item.Counter++;

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
			//to do zapisz do db
		}
	}
}
