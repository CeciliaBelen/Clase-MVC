using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcABM.Controllers
{
    public class ShipperController : Controller
    {
        Models.NorthwindEntities db = new Models.NorthwindEntities();
        // GET: Shipper
        public ActionResult Index()
        {
            var lista = (from s in db.Shippers select s).ToList();
            return View(lista);
        }
        //Método de acción "Create GET"
        [HttpGet] //Parte del modo de compartir con el usuario
        public ActionResult Create()
        {
            Models.Shipper shipper = new Models.Shipper();
            shipper.Phone = "000";
            return View(shipper);
        }
        [HttpPost]
        public ActionResult Create(Models.Shipper shipper)
        {
            db.Shippers.Add(shipper);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}