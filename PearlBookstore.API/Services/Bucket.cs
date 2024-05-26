using PearlBookstore.API.Models;
using PearlBookstore.Shared;

namespace PearlBookstore.API.Services
{
	public class Bucket
	{
		public List<AddItemToBucketRequest> Items { get; } = new List<AddItemToBucketRequest>();
	
	}
}
