using PearlBookstore.Shared.RequestsResponses.Requests;

namespace PearlBookstore.API.Services
{
    public class ReturnBucket
    {
        public List<AddItemToBucketRequest> Items { get; } = new List<AddItemToBucketRequest>();
    }
}
