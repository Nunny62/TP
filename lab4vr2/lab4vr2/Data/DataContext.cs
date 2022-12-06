global using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace lab4vr2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Practice22;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Order> Order { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Making_an_order> Making_an_orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Test> Tests { get; set; }
    }
}
