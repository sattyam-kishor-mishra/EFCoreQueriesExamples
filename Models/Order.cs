using System.ComponentModel.DataAnnotations;

namespace EFCoreQueriesExample.Models
{
    public class Order
    {
        [Key] 
        public required Guid OrderId { get; set; } = new Guid();

        public required Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
