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


    }
}
