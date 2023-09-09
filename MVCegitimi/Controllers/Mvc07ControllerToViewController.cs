using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCegitimi.Controllers
{
    public class Mvc07ControllerToViewController : Controller
    {
        // GET: Mvc07ControllerToView
        public ActionResult Index()
        {
            ViewBag.KategoriAdi = "Bilgisayar";
            ViewData["UrunAdi"] = "Yenova Tablet";
            TempData["UrunFiyat"] = 4990;

            return View();
        }
    }
}