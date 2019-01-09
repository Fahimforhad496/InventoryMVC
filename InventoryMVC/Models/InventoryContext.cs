using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InventoryMVC.Models
{
    public class InventoryContext : DbContext
    {

        public InventoryContext() : base("InventoryContext")
        {
        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}