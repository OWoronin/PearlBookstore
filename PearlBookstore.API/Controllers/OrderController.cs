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

    public class OrderController(AppDbContext context, OrderBucket bucket, CurrentEmployee employee) : ControllerBase
    {
        [HttpPost("AddToOrder")]
        public async Task<DefaultResponse> AddToOrder(AddItemToBucketRequest request)
        {
            string prefix = "Nie udało się dodać publikacji do koszyka zamówienia.";
            DefaultResponse response = new();

            var item = context.Items.Where(i => i.Id == request.ItemId && i.Types.Select(t => t.TypeId).Contains(request.TypeId)).FirstOrDefault();

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

        [HttpPost("RemoveFromOrder")]
        public async Task<DefaultResponse> RemoveFromOrder(RemoveFromBucketRequest request)
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
            string prefix = "Nie udało się pudsumować kwoty koszyka zamówienia.";
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
            string prefix = "Nie udało się zmodyfikować ilości publikacji w zamówieniu.";
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
                response.Message = $"{prefix} Dana publikacja nie znajduje się w koszyku zamówienia.";
                return await Task.FromResult(response);
            }

            itemInBucket.ActionCounter = request.ActionCounter;

            response.IsSuccess = true;

            return await Task.FromResult(response);
        }

        [HttpGet("AcceptOrder")]
        public async Task<AcceptResponse> AcceptOrder()
        {
            string prefix = "Nie udało się zaakceptować zakupu.";
            AcceptResponse response = new();
            if (bucket.Items.Count < 1)
            {
                response.IsSuccess = false;
                response.Message = $"{prefix} Koszyk zamówienia jest pusty.";
                return await Task.FromResult(response);
            }

            using var transaction = context.Database.BeginTransaction();

            var sum = bucket.Items.Sum(it => it.Price * it.ActionCounter);

            DateTime current = DateTime.Now;
            DateOnly orderDate = new(current.Year, current.Month, current.Day);
            Guid newGuid = Guid.NewGuid();
            string guidString = newGuid.ToString("N");
            string firstEightChars = guidString[..8];

            string evidenceID = $"{orderDate.Year}_{orderDate.Month}_{orderDate.Day}_{bucket.Items[0].EmployeeId}_O_{firstEightChars}";

            DateOnly devileryDate = orderDate.AddDays(5);

            var status = await context.Status.Where(s => s.Id == 1).FirstAsync();

            Order order = new Order()
            {
                Price = sum,
                Date = orderDate,
                OrderEvidence = evidenceID,
                ClientName = bucket.ClientInOrder.Name,
                ClientSurname = bucket.ClientInOrder.Surname,
                ClientEmail = bucket.ClientInOrder.Email,
                ClientPhone = bucket.ClientInOrder.Phone,
                EmployeeId = bucket.Items[0].EmployeeId,
                Employee = employee.Current,
                Status = status,
                StatusId = status.Id,
            };

            context.Orders.Add(order);
            //context.SaveChanges();

            for (int i = 0; i < bucket.Items.Count; i++)
            {
                var item = context.Items.Where(it => it.Id == bucket.Items[i].ItemId).FirstOrDefault();

                if (item == null)
                {
                    response.IsSuccess = false;
                    response.Message = $"{prefix} Publikacja w koszyku zamówienia nie znajduje się w systemie.";
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

                OrderItem orderItem = new OrderItem()
                {
                    ItemId = bucket.Items[i].ItemId,
                    Item = item,
                    OrderId = order.Id,
                    Counter = bucket.Items[i].TypeId,
                    TypeId = bucket.Items[i].TypeId,
                    Type = itemType.Type,
                    Order = order,
                    Price = bucket.Items[i].Price
                };

                context.ItemsOrder.Add(orderItem);
            }

            if (context.SaveChanges() == bucket.Items.Count + 1)
            {
                await transaction.CommitAsync();
                bucket.Items.Clear();
                response.IsSuccess = true;
                response.Price = sum;
                response.Date = devileryDate;
                response.Evidence = evidenceID;
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
