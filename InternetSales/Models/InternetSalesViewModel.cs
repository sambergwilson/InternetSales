using InternetSales.DataAccess.Model;
using InternetSales.DataAccess.Repository;

namespace InternetSales.Models
{
    public class InternetSalesViewModel
    {
        public List<InternetSalesModel>? CustomerList { get; set; }
        public InternetSalesModel? CurrentCustomer { get; set; }

    }
}
