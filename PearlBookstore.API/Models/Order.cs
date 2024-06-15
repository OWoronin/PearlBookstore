using System.ComponentModel.DataAnnotations;

namespace PearlBookstore.API.Models
{
    public class Order
    {
        [Key]

        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string OrderEvidence { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public decimal Price { get; set; }
        //
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; } = null!;
        //
        public int EmployeeId { get; set; }
        public User Employee { get; set; } = null!;
        //
        public ICollection<OrderItem> OrdersItems { get; } = new List<OrderItem>();
    }
}
