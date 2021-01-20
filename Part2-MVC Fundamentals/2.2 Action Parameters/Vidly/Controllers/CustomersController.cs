using System.Web.Mvc;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET
      private  CustomerRepository _customers = null;

      public CustomersController()
      {
          _customers = new CustomerRepository();
      }

      public ActionResult Index()
      {
          var customers = _customers.GetCustomers();
            return View(customers);
        }
      [Route("Customers/Details/{id}")]
      public ActionResult Details(int? id)
      {
          Customer customer = null;

          if (id == null)
          {
              return HttpNotFound();
          }

          if (_customers.GetCustomer((int)id) == null)
          {
              return HttpNotFound();
          }

          if (_customers.GetCustomer((int) id) != null)
          {
              customer = _customers.GetCustomer((int) id);
          }


          return View(customer);
      }
    }
}