using System.ComponentModel.DataAnnotations;

namespace EFCoreQueriesExample.Models
{
    public class Customer
    {
        [Key]
        public required Guid CustomerId { get; set; } = new Guid();

        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
