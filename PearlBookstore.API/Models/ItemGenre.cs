using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class ItemGenre
	{
		[Key]
		public int Id { get; set; }//useless, but needed in library 
		public int ItemId { get; set; }
		public int GenreId { get; set; }
	}
}
