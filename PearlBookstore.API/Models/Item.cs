using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Item
    {

        //TO DO connect Item table with genre table, available in storage class
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int YearPublication { get; set; }

        //

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        //

        public ICollection<ItemGenre> Genres { get; } = new List<ItemGenre>();

        public ICollection<ItemType> Types { get; } = new List<ItemType>();

        //

        public ICollection<ItemPurchase> Purchases { get; } = [];

        public ICollection<ItemReturn> Returns { get; } = [];

        public ICollection<OrderItem> Orders { get; } = [];

    }
}
