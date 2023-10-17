using InternetSales.DataAccess.Context;
using InternetSales.DataAccess.Model;
using InternetSales.DataAccess.Repository;
using InternetSales.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;

namespace InternetSales.Controllers
{
    public class InternetSalesController : Controller
    {
        private readonly InternetSalesRepository _repo;

        public InternetSalesController()
        {
            _repo = new InternetSalesRepository();
        }
        /*public IActionResult Index()
        {
            var model = new InternetSalesViewModel();
            model.CustomerList = GetAll();
            model.CurrentCustomer = model.CustomerList.FirstOrDefault();

            return View(model);
        }*/

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

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(InternetSalesModel model)
        {
            if (ModelState.IsValid)
            {
                var incomingInfo = new InternetSalesModel(model.CustomerId, model.BusinessOwner, model.BusinessName,
                    model.BusinessAddress, model.PhoneNumber, model.PurchasedInternet, model.PurchasedPhone, model.PurchasedCellService, model.TvService);

                _repo.Update(incomingInfo);

                return RedirectToAction("Index", incomingInfo);
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            _repo.Delete(GetCurrent(id));

            var model = new InternetSalesViewModel();
            model.CustomerList = GetAll();

            model.IsActionSuccess = true;
            model.ActionMessage = "Customer Information has been deleted successfully";

            return View("Index", model);

        }

        public IActionResult Index(string searchTerm)
        {
            var model = new InternetSalesViewModel();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                model.CustomerList = SearchCustomers(searchTerm);
            }
            else
            {
                model.CustomerList = GetAll();
            }

            model.CurrentCustomer = model.CustomerList.FirstOrDefault();

            return View(model);
        }

        private List<InternetSalesModel> SearchCustomers(string searchTerm)
        {
            return _repo.GetAll().Where(c => c.BusinessName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
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
