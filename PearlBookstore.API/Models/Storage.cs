using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class Storage
	{
		[Key]
		public int Id { get; set; }	//needed in library 
		public int ItemId { get; set; }	
		public int Count { get; set; }
	}
}
