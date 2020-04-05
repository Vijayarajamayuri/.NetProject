using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ResApplication.Data
{
    public class ResContext : DbContext
    {

        public ResContext() : base("ResContext")
        {
        }

        public DbSet<Restaurent> Restaurents { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}