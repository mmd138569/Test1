using System.Linq;
using Microsoft.EntityFrameworkCore;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Test1.Models.Entities;

namespace Test1.Core.Context;

public class DataBaseContext:DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Models.Entities.Product> Products { get; set; }
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
        modelBuilder.Entity<Models.Entities.Product>().HasKey(e => e.Id);
        modelBuilder.Entity<Personal>().HasKey(e => e.Id);
        modelBuilder.Entity<Date>().HasNoKey();
        modelBuilder.Entity<Order>()
            .HasOne(e => e.Personal)
            .WithMany(d => d.Orders)
            .HasForeignKey(e => e.PersonalID);
        modelBuilder.Entity<OrderDetail>()
            .HasOne(e => e.Product)
            .WithMany(d => d.OrderDetails)
            .HasForeignKey(e => e.ProductID);
        modelBuilder.Entity<OrderDetail>()
            .HasOne(e => e.Order)
            .WithMany(d => d.orderDetails)
            .HasForeignKey(e => e.OrderID);
    }
}