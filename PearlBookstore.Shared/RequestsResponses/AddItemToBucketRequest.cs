namespace PearlBookstore.Shared
{
    public class AddItemToBucketRequest
    {
        public int ItemId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Price { get; set; }  

        public bool IsAudioBook { get; set; }
        public bool IsThick { get; set; }
        public bool IsSoft { get; set; }
        public bool IsEbook { get; set; }

    }
}
