namespace Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Order
{
    public int Id { get; set; }
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public Installement Installement { get; set; }
    public double ProductPrice { get; set; }
    public Customer Customer { get; set; }


}
