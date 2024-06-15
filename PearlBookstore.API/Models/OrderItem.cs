using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int Counter { get; set; }
        public decimal Price { get; set; }

        //
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        //
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        //
        public int TypeId { get; set; }
        public Type Type { get; set; } = null!;
    }
}
