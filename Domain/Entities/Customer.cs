namespace Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Customer
{
    public int CustomerId { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    public List<Order> Orders { get; set; }
}