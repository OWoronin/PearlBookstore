using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Item
	{

		//TO DO connect Item table with genre table, available in storage class
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int AuthorId { get; set; }
		public int TypeId { get; set;}
		public double Price { get; set; }	
		public int YearPublication { get; set; }



	}
}
