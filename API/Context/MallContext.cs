using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ObjectLibrary;

namespace Context
{
    public class MallContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SLAGGARWAL1IN; Database=OnlineMallData; Integrated Security=True");
        } 
    }
}
