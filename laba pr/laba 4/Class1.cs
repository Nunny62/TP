using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using laba_4.Domains;

namespace laba_4
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Order { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Making_an_order> Making_an_orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}