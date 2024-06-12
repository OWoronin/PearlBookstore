namespace PearlBookstore.Shared.RequestsResponses.Requests
{
    public class ModifyPriceAndCountOfItemInBucketRequest
    {
        public int ItemId { get; set; }
        public int TypeId { get; set; }
        public int ActionCounter { get; set; }
        public decimal Price { get; set; }
    }
}
