using EmlakOtomasyonProjesi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonProjesi.Context
{
    public class MyDbContext:DbContext
    {
        
        public DbSet<CompanyEntity> Companies => Set<CompanyEntity>();
        public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
        public DbSet<HousingEntity> Housings => Set<HousingEntity>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new HousingEntityConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=localHost; port=5432; Database=EmlakOtomasyonDb; user ID=postgres; password=123456;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
