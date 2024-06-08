namespace PearlBookstore.Shared.RequestsResponses
{
    public class AddItemToBucketRequest
    {
        public int ItemId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Price { get; set; }

        public int TypeId { get; set; }

    }
}
