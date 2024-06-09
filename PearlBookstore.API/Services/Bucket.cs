using PearlBookstore.API.Models;
using PearlBookstore.Shared.RequestsResponses.Requests;

namespace PearlBookstore.API.Services
{
    public class Bucket
	{
		public List<AddItemToBucketRequest> Items { get; } = new List<AddItemToBucketRequest>();
	
	}
}
