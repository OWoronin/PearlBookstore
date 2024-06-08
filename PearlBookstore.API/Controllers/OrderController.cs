using Microsoft.AspNetCore.Mvc;
using PearlBookstore.API.DB;
using PearlBookstore.API.Models;
using PearlBookstore.API.Services;
using PearlBookstore.Shared;
using PearlBookstore.Shared.RequestsResponses;

namespace PearlBookstore.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class OrderController(AppDbContext context, Bucket bucket) : ControllerBase
	{
		[HttpPost("AddToOrder")]
		public async Task<bool> AddToOrder(AddItemToBucketRequest request)
		{

			var item = context.Items.Where(i => i.Id == request.ItemId).FirstOrDefault();

			if (item == null)
			{
				return await Task.FromResult(false);
			}


			bucket.Items.Add(request);
			return await Task.FromResult(true);
		}

		[HttpPost("RemoveFromOrder")]
		public async Task<bool> RemoveFromOrder(int ItemId)
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

		[HttpGet("AcceptOrder")]
		//TO DO TABELA ZAMOwien
		public async Task<bool> AcceptOrder()
		{
			if (bucket.Items.Count < 1)
			{
				return await Task.FromResult(false);
			}

			DateTime current = DateTime.Now;
			DateOnly orderDate = new DateOnly(current.Year, current.Month, current.Day);
			string evidence = $"{orderDate.Year}_{orderDate.Month}_{orderDate.Day}_{bucket.Items[0].EmployeeId}_{new Guid().ToString()}";

			using var transaction = context.Database.BeginTransaction();

			Order order = new Order()
			{
				EmployeeId = bucket.Items[0].EmployeeId,
				Date = orderDate,
				StatusId = 1,
				OrderEvidence = evidence
			};

			context.Orders.Add(order);
			context.SaveChanges();

			for (int i = 0; i < bucket.Items.Count; i++)
			{

				OrderItem oi = new OrderItem()
				{
					ItemId = bucket.Items[i].ItemId,
					OrderId = order.Id
				};

				int counter = context.SaveChanges(); 
				if(counter == 0)
				{
					transaction.Rollback();
					return await Task.FromResult(false);
				}


			}

			transaction.Commit();
			bucket.Items.Clear();
			return await Task.FromResult(true); 
		}

		[HttpPost("ChangeOrderStatus")]
		public async Task<bool> ChangeOrderStatus(ChangeOrderStatusRequest request)
		{
			var order = context.Orders.Where(o => o.Id == request.OrderId).FirstOrDefault(); 

			if (order == null)
			{
				return await Task.FromResult(false);
			}

			order.StatusId = request.OrderId;

			int counter = context.SaveChanges();
			if (counter == 0)
			{
				return await Task.FromResult(false);
			}


			return await Task.FromResult(true);
		}
	}
}
