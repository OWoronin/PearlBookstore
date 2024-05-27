using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemType> Items { get; } = new List<ItemType>();
    }
}
