namespace Test1.Models;

public class OrderDetail
{
    public int Id { get; set; }
    public int ProductID { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
    public int OrderID { get; set; }
    public int SumPrice { get; set; }
}