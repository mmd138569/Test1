namespace Test1.Models.Entities;

public class OrderDetail
{
    public int Id { get; set; }
    public int ProductID { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
    public int OrderID { get; set; }
    public int SumPrice { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
}