using System.Collections.Generic;

namespace Test1.Models.Entities;

public class Personal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CompanyName { get; set; }
    public string Email { get; set; }
    public ICollection<Order> Orders { get; set; }
}