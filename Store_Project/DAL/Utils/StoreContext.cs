using DAL.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utils
{
    public class StoreContext : IdentityDbContext<Employee>
    {
        public StoreContext(): base("DefaultConnection")
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Types> Types { get; set; }
        
    }
}
