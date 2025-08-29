using Microsoft.EntityFrameworkCore;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Test1.Models;

namespace Test1.Core.Context;

public class DataBaseContext:DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Test1.Models.Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Personal> Personals { get; set; }

    public DataBaseContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=SampleProject; Integrated Security=True; Encrypt=False");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().HasKey(e => e.Id);
        modelBuilder.Entity<OrderDetail>().HasKey(e => e.Id);
        modelBuilder.Entity<Test1.Models.Product>().HasKey(e => e.Id);
        modelBuilder.Entity<Personal>().HasKey(e => e.Id);

    }
}