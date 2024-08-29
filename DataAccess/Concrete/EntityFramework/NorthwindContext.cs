using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        private readonly IConfiguration _configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Projenin hangi DB ile ilişkili olduğunu gösteren fonk. 
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:MsSQL"]);
    
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        // koddaki class'larımızın DB'deki hangi tabloya karşılık geldiğini belirttik

    }
}
