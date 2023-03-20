namespace Domain.Entities;
public class Product
{
    public int Id {get;set;}
    public string ProductName {get;set;}
    public decimal ProductPrice {get;set;}
    public decimal TotalAmout {get;set;}
    public Category Category {get;set;}
    public Installement Installment {get;set;}
    public List <Order>Orders{get;set;}
}
public enum Category
{
    Smartphone = 0,
    Computer = 1,
    Television = 2
}
public enum Installement
{
    Three = 3,
    Six = 6,
    Nine = 9,
    Twelve = 12,
    Eighteen = 18,
    TwentyFour = 24
}