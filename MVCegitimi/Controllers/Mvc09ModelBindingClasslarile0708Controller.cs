using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCegitimi.Models;  //modelsteki klası tanımladık

namespace MVCegitimi.Controllers
{
    public class Mvc09ModelBindingClasslarile0708Controller : Controller
    {
        // GET: Mvc09ModelBindingClasslarile0708
        public ActionResult Index()  //Model kalsöründe class tanımladık
        {
            var sayfamodeli = new AnasayfaViewModel
            {
                adresNesnesi = new Adres { Sehir = "bursa", ilce = "yildirim", AcikAdres = "sirinevler mah." },
                kullaniciNesnesi=new Kullanici 
                {
                    Ad = "yusuf",
                    Soyad = "aras",
                    Email = "yusuf@gmail.com"
                }
            };
            return View(sayfamodeli);
        }

        public ActionResult Kullanici()   //add view Empty seç altındaki classı seç
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "yusuf",
                Soyad = "aras",
                Email = "yusuf@gmail.com"
            };

            return View(kullanici);
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici kullanici)
        {
            ViewBag.mesaj = "Kullanıcı Adı: " + kullanici.KullaniciAdi;
            ViewData["Vdata"] = "Kullanıcı Adı SOyadı: " + kullanici.Ad+" "+kullanici.Soyad;
            TempData["Tdata"] = "Email: " + kullanici.Email;
            return View();
        }
        public ActionResult Adres()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres)
        {
            ViewBag.mesaj = "Şehir: " + adres.Sehir;
            ViewData["Vdata"] = "İlçe: " + adres.ilce;
            TempData["Tdata"] = "Açık adres: " + adres.AcikAdres;
            return View();
        }
    }
}