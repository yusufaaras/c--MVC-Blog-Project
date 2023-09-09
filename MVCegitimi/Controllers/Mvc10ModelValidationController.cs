using MVCegitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCegitimi.Controllers
{
    public class Mvc10ModelValidationController : Controller
    {
        // GET: Mvc10ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUye(Uye uye)
        {
            if(ModelState.IsValid) //model durumu geçerli ise
            {
                ViewBag.UyeBilgi = $"Üye Adı:{uye.Ad} <hr> Soyad:{uye.Soyad} <hr>Email:{uye.Email} <hr> Sifre: {uye.Sifre}";
            }
            return View();
        }
        public ActionResult UyeDuzenle(int id)
        {
            Uye uye = new Uye()
            {
                Ad = "ysuuf",
                Soyad="aras",
                Email="yusuf@gmail.com",

            };
            return View(uye);
        }
        [HttpPost]
        public ActionResult UyeDuzenle(Uye uye)
        {
            //değişiklikler veri tabanına gönderilip işlenir
            return View(uye);
        }
        public ActionResult UyeListesi()
        {
            var uyeListesi=new List<Uye>()
            {
                new Uye()
                {
                    Ad = "ysuuf",
                    Soyad = "aras",
                    Email = "yusuf@gmail.com",

                },
                new Uye()
                {
                    Ad = "ali",
                    Soyad = "kaya",
                    Email = "ali@gmail.com",

                }
            };
            return View(uyeListesi);
        }
        public ActionResult UyeSil(int id)
        {
            Uye uye = new Uye()
            {
                Id=id,
                Ad = "ysuuf",
                Soyad = "aras",
                Email = "yusuf@gmail.com",

            };
            //burada kayıt silinir
            return View(uye);
        }
    }
}