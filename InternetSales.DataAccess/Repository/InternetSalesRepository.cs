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

        /*public InternetSalesRepository(InternetSalesContext dbContext)
        {
            _dbContext = dbContext;
        }*/

        public int Create(InternetSalesModel model)
        {
            _dbContext.Add(model);
            _dbContext.SaveChanges();

            return model.CustomerId;
        }

        public List<InternetSalesModel> GetAll()
        {
            List<InternetSalesModel> salesList = _dbContext.InternetSales.ToList();

            return salesList;
        }
    }
}
