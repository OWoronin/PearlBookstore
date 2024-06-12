namespace PearlBookstore.Shared.RequestsResponses.Requests
{
    public class ModifyCountOfItemInBucketRequest
    {
        public int ItemId { get; set; }
        public int TypeId { get; set; }

        public int ActionCounter { get; set; }
    }
}
