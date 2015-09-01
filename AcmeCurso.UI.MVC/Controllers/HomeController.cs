using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCurso.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acme Cursos";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contato";

            return View();
        }
    }
}