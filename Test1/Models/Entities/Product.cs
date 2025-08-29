using System.Collections.Generic;

namespace Test1.Models.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Code { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}