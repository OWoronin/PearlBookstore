namespace PearlBookstore.API.Models
{
    public class ItemPurchase
    {
        public int Id { get; set; }
        public int Counter { get; set; }
        //
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        //
        public int TypeId { get; set; }
        public Type Type { get; set; } = null!;

        public int PurchaseID { get; set; }

        public Purchase Purchase { get; set; } = null!;
    }
}
