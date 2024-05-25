using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Login { get; set; }
		public string Name { get; set; }	
		public string Surname { get; set; }
		public int Role { get; set; }

		
	}
}
