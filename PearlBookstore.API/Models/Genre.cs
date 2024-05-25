using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Genre
	{
		[Key]
		public int Id { get; set; }
		public ICollection<Item> Items { get; }= new List<Item>();

		public string Name { get; set; }
	}
}
