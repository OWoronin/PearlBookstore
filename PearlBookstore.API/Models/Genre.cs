using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemGenre> Items { get; } = new List<ItemGenre>();

    }
}
