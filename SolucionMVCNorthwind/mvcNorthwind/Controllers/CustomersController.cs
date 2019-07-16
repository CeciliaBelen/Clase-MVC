using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcNorthwind.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            Models.NorthwindEntities db = new Models.NorthwindEntities();
            var lista = (from c in db.Customers
                         select c).ToList();
            return View(lista);
        }
    }
}