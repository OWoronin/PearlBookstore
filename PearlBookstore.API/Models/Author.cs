using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Author
	{
		//TO DO search with author or title, list of every author's books
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }

		public ICollection<Item> Items { get; } = new List<Item>();
	}
}
