using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVistas.Controllers
{
    public class JQueryController : Controller
    {
        // GET: JQuery
        public ActionResult Index()
        {
            @ViewBag.Hora = DateTime.Now.ToString();
            return View();
        }
        public ActionResult Vista1()
        {
            @ViewBag.Hora = DateTime.Now.ToString();
            return PartialView("_Vista1");
        }
        public ActionResult Vista2()
        {
            @ViewBag.Hora = DateTime.Now.ToString();
            return PartialView("_Vista2");
        }

    }
}