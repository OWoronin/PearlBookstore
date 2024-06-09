using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Purchase
    {
        [Key]

        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        public int Counter { get; set; }
        public int EmployeeId { get; set; }
        public User Employee { get; set; } = null!;
        public string PaymentId { get; set; }

        public DateOnly Date { get; set; }
    }
}

