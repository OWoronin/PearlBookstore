using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class OrderItem
	{
		[Key]
		public int Id { get; set; }

		public int ItemId { get; set; }
		public int OrderId { get; set; }
		public Order Order { get; set; } = null!;
	}
}
