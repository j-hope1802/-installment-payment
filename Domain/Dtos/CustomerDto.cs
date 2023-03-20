namespace Domain.Dtos;
public class CustomerDto
{
    public int CustomerId { get; set; }

    public string PhoneNumber { get; set; }
}
public class AddCustomer : CustomerDto
{

}