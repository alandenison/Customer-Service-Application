using Microsoft.AspNetCore.Mvc;
using CustomerServiceApp.Models;
using System.Linq;

namespace CustomerServiceApp.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        private CustomerServiceAppContext db = new CustomerServiceAppContext();
        public IActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisCustomer = db.Customers.FirstOrDefault(Customers => Customers.CustomerId == id);
            return View(thisCustomer);
        }
    }
}