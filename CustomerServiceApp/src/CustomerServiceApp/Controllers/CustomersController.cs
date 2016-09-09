using Microsoft.AspNetCore.Mvc;
using CustomerServiceApp.Models;
using System.Linq;

namespace CustomerServiceApp.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerServiceAppContext db = new CustomerServiceAppContext();
        public IActionResult Index()
        {
            return View(db.Customers.ToList());
        }
    }
}