using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemType> Types { get; } = new List<ItemType>();

        public ICollection<ItemPurchase> Purchases { get; set; } = [];

        public ICollection<ItemReturn> Returns { get; set; } = [];

        public ICollection<OrderItem> Orders { get; set; } = [];
    }
}
