using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Purchase
	{
		[Key]

		public int Id { get; set; }
		public int ItemId { get; set; }
		public int Counter { get; set; }
		public int EmployeeId { get; set; }
		public string PaymentId { get; set; }

		public DateOnly Date { get; set; }
	}
}

