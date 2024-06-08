using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Return
	{
		[Key]

		public int Id { get; set; }
		public int ItemId { get; set; }
		public int Counter { get; set; }

		public decimal Price { get; set; }
		public int EmployeeId { get; set; }
		public DateOnly Date { get; set; }

	}
}

