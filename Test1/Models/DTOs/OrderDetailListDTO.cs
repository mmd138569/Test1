namespace Test1.Models.DTOs;

public class OrderDetailListDTO
{
    public string ProductName { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public decimal SumPrice { get; set; }
}