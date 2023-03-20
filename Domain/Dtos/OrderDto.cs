using Domain.Entities;

namespace Domain.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string PhoneNumber { get; set; }
    public Category Category { get; set; }
    public Installement Installement { get; set; }
    public double ProductPrice { get; set; }

}