namespace MasterASP.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MasterASP.Models;

    public partial class AppDB : IdentityDbContext<ApplicationUser>
    {

        public static AppDB Create()
        {
            return new AppDB();
        }
        public AppDB()
            : base("name=AppDB")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<MasterASP.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<MasterASP.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<MasterASP.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<MasterASP.Models.Shipper> Shippers { get; set; }

        public System.Data.Entity.DbSet<MasterASP.Models.OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<MasterASP.Models.Cart> Carts { get; set; }
    }
}
