using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCegitimi.Controllers
{
    public class Mvc11SessionCookieController : Controller
    {
        // GET: Mvc11SessionCookie
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies["kullanici"] != null)
            {
                ViewBag.kuki=HttpContext.Request.Cookies["kullanici"].Value;
            }
            return View();
        }
        public ActionResult Sessions() //ilgili session ı yakalayıp göstereceğimi sayfa
        {
            if (Session["deger"] != null)
            {
                ViewBag.SessDeger = Session["deger"].ToString();
            }
            else
            {
                ViewBag.SessDeger = " Session değeri boş";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Sessions(string text) //ilgili session ı yakalayıp Sil
        {
            if (Session["deger"] != null)
            {
                //Session["deger"]=null;  //2.yöntem
                Session.Remove("deger");
            }
            else
            {
                ViewBag.SessDeger = " Session değeri boş";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            //Index teki text yazan sessiondaki değeri tutar (string text sayesinde)
            Session["deger"] = text;
            //Session.Add("deger", text);//2. yöntem
            return View();
        }
        public ActionResult CookieOlustur(string kuki)
        {
            HttpCookie cookie = new HttpCookie("kullanici", "kuki"); //cookie olusturma
            HttpContext.Response.Cookies.Add(cookie); //oluşan cookie yi cihaza atma
            ViewBag.Kullanici = HttpContext.Request.Cookies["kullanici"].Value;// cihazdan okuma
            return View("Index");
        }
        public ActionResult CookieSil()
        {
            if (HttpContext.Request.Cookies["kullanici"] != null)
            {
                HttpContext.Response.Cookies["kullanici"].Expires = DateTime.Now.AddSeconds(-3);
                ViewBag.Kullanici = "kuki silindi";
            }

            return RedirectToAction("Index");//View("Index");
        }
    }
}