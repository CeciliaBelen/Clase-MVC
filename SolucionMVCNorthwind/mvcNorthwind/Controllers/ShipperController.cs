using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcNorthwind.Controllers
{
    public class ShipperController : Controller
    {
        // GET: Shipper
        public ActionResult Index()
        {
            //1° se crea una clase de contexto
            Models.NorthwindEntities db = new Models.NorthwindEntities();
            //Con LINQ se recupera la lista de Shippers
            var lista = (from s in db.Shippers
                        select s).ToList();
            return View(lista);
        }
    }
}