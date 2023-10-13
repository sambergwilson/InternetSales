using InternetSales.DataAccess.Context;
using InternetSales.DataAccess.Model;
using InternetSales.DataAccess.Repository;
using InternetSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetSales.Controllers
{
    public class InternetSalesController : Controller
    {
        private readonly InternetSalesRepository _repo;

        public InternetSalesController()
        {
            _repo = new InternetSalesRepository();
        }
        public IActionResult Index()
        {
            var model = new InternetSalesViewModel();
            model.CustomerList = GetAll();

            return View(model);
        }

        private List<InternetSalesModel> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
