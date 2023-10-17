using InternetSales.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSales.DataAccess.Context
{
    public class InternetSalesContext : DbContext
    {
        public InternetSalesContext(DbContextOptions options) : base(options)
        {

        }
        public InternetSalesContext()
        {

        }

        public DbSet<InternetSalesModel> InternetSales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-GMO2ILF\\SQLEXPRESS02;Database=InternetSalesDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InternetSalesModel>(
                entity =>
                {
                    entity.HasKey(e => e.CustomerId);
                    entity.Property(e => e.CustomerId);
                    entity.Property(e => e.BusinessOwner);
                    entity.Property(e => e.BusinessName).IsRequired();
                    entity.Property(e => e.BusinessAddress).IsRequired();
                    entity.Property(e => e.PhoneNumber).IsRequired();
                    entity.Property(e => e.PurchasedInternet).IsRequired();
                    entity.Property(e => e.PurchasedPhone).IsRequired();
                    entity.Property(e => e.PurchasedCellService).IsRequired();
                    entity.Property(e => e.TvService).IsRequired();
                });
        }
    }
}
