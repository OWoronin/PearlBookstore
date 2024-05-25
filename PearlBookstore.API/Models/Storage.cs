using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Storage
	{
		[Key]
		public int Id { get; set; }	//needed in library 
		public ICollection<Item> Items { get;} = new List<Item>();
		public int Count { get; set; }


	}
}
