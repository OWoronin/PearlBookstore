using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Order
	{
		[Key]

		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public DateOnly Date { get; set; }
		public int StatusId { get; set; }
		public OrderStatus Status { get; set; } = null!;

		public ICollection<OrderItem> OrdersItems { get; } = new List<OrderItem>();
		public string OrderEvidence { get; set; }
	}
}
