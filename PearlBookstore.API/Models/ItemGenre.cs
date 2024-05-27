using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class ItemGenre
    {
        [Key]

        public int Id { get; set; }

        public int ItemId { get; set; }

        public int GenreId { get; set; }
        public Item Item { get; set; } = null!;
        public Genre Genre { get; set; } = null!;
    }
}
