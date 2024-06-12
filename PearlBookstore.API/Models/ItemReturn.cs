namespace PearlBookstore.API.Models
{
    public class ItemReturn
    {
        public int Id { get; set; }
        public int Counter { get; set; }
        public decimal Price { get; set; }
        //
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        //
        public int TypeId { get; set; }
        public Type Type { get; set; } = null!;

        public int ReturnID { get; set; }

        public Return Return { get; set; } = null!;
    }
}
