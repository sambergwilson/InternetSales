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
            modelBuilder.Entity<InternetSalesModel>().HasData(
                new InternetSalesModel { CustomerId = 1, BusinessOwner = "John Doe", BusinessName = "Alltel", BusinessAddress = "123 Happy Street", PhoneNumber = "1234567890", PurchasedCellService = false, PurchasedInternet = false, PurchasedPhone = false, TvService = false },
                new InternetSalesModel { CustomerId = 2, BusinessOwner = "John Wilson", BusinessName = "360 Communications", BusinessAddress = "123 Other Street", PhoneNumber = "1234567890", PurchasedCellService = true, PurchasedInternet = true, PurchasedPhone = true, TvService = true }
                );
        }
    }
}
