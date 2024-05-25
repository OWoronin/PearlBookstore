using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class ItemType
	{
		[Key]
		public int Id { get; set; }	//useless, needed in library 
		public int TypeId { get; set; }
		public int ItemId { get; set; }
	}
}
