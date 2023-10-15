using InternetSales.DataAccess.Context;
using InternetSales.DataAccess.Model;
using InternetSales.DataAccess.Repository;
using InternetSales.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InternetSalesModel model)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(model);
                var updated = new InternetSalesViewModel();

                updated.CustomerList = GetAll();

                return View("Index", updated);
            }
            

            return View("Create");
        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var model = new InternetSalesViewModel();

            model.CurrentCustomer = GetCurrent(id);
            
            return View("Edit");
        }

        [HttpPost]
        public IActionResult Edit(InternetSalesModel model)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(model);
                var updated = new InternetSalesViewModel();

                updated.CustomerList = GetAll();

                return View("Index", updated);
            }


            return View("Edit");
        }

        private List<InternetSalesModel> GetAll()
        {
            return _repo.GetAll();
        }

        private InternetSalesModel GetCurrent(int Id)
        {
            return _repo.GetCurrent(Id);
        }
    }
}
