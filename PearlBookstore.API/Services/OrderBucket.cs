using PearlBookstore.Shared.RequestsResponses.Requests;

namespace PearlBookstore.API.Services
{
    public class OrderBucket
    {
        public List<AddItemToBucketRequest> Items { get; } = new List<AddItemToBucketRequest>();
        public ClientInOrderRequest ClientInOrder { get; set; }
    }
}
