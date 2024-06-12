using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Purchase
    {
        [Key]

        public int Id { get; set; }
        public string PurchaseID { get; set; }
        public DateOnly Date { get; set; }
        public decimal TotalPrice { get; set; }
        //
        public int EmployeeId { get; set; }
        public User Employee { get; set; } = null!;

        //

        public ICollection<ItemPurchase> Items { get; set; } = [];

        public ICollection<Return> Returns { get; set; } = [];

    }
}

