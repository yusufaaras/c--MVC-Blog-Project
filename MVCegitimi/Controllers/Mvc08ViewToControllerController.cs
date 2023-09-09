using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCegitimi.Controllers
{
    public class Mvc08ViewToControllerController : Controller
    {
        // GET: Mvc08ViewToController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        /* public ActionResult Index(String text)             //1. yol
         {
             var textbox = Request.Form["Text1"];
             var ddl = Request.Form["liste"];
             var chb = Request.Form.GetValues("cbOnay")[0];

             ViewBag.mesaj = "text box değeri"+textbox;
             ViewData["Vdata"] = "ddl den gelen değer"+ddl;
             TempData["Tdata"] = "cbOnayın seçili deeğri "+chb;

             return View();
         }*/
        public ActionResult Index(String Text1, bool cbOnay, string liste)      //2. yol
        {

            ViewBag.mesaj = "text box değeri " + Text1;
            ViewData["Vdata"] = "ddl den gelen değer" + liste;
            TempData["Tdata"] = "cbOnayın seçili deeğri " + cbOnay;

            return View();
        }
    }
}