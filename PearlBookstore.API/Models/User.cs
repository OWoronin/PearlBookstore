using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        public ICollection<Purchase> Purchases { get; set; } = [];

        public ICollection<Return> Returns { get; set; } = [];

    }
}
