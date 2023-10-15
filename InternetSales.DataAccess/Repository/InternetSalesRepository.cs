using InternetSales.DataAccess.Context;
using InternetSales.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSales.DataAccess.Repository
{
    public class InternetSalesRepository
    {
        private readonly InternetSalesContext _dbContext;

        public InternetSalesRepository()
        {
            _dbContext = new InternetSalesContext();
        }

        public int Create(InternetSalesModel model)
        {
            _dbContext.Add(model);
            _dbContext.SaveChanges();

            return model.CustomerId;
        }

        public int Update(InternetSalesModel model)
        {
            var existingCustomer = _dbContext.InternetSales.Find(model.CustomerId);

            existingCustomer.BusinessOwner = model.BusinessOwner;
            existingCustomer.BusinessName = model.BusinessName;
            existingCustomer.BusinessAddress = model.BusinessAddress;
            existingCustomer.PhoneNumber = model.PhoneNumber;
            existingCustomer.PurchasedInternet = model.PurchasedInternet;
            existingCustomer.PurchasedInternet = model.PurchasedInternet;
            existingCustomer.PurchasedPhone = model.PurchasedPhone;
            existingCustomer.PurchasedCellService = model.PurchasedCellService;
            existingCustomer.TvService = model.TvService;

            _dbContext.SaveChanges();

            return existingCustomer.CustomerId;
        }

        public List<InternetSalesModel> GetAll()
        {
            List<InternetSalesModel> salesList = _dbContext.InternetSales.ToList();

            return salesList;
        }

        public InternetSalesModel GetCurrent(int customerId)
        {
            var model = _dbContext.InternetSales.Find(customerId);

            return model;
        }
    }
}
