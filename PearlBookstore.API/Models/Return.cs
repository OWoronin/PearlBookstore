using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Return
    {
        [Key]

        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public decimal TotalReturn { get; set; }
        //
        public int EmployeeID { get; set; }
        public User Employee { get; set; }

        //
        public int PurchaseID { get; set; }
        public Purchase Purchase { get; set; }

        public ICollection<ItemReturn> ReturnItems { get; set; } = [];

    }
}

