using MVCegitimi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCegitimi.Controllers
{
    public class Mvc13ViewResultController : Controller
    {
        // GET: Mvc13ViewResult
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Index2()
        {
            //return Redirect("/home/Index");
            return Redirect("https://www.udemy.com/course/full-stack-dotnet-developer-egitimi/learn/lecture/30956166?start=15#questions");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index" ,id=5 });
        }
        public PartialViewResult KategroileriPartialIleGetir()
        {
            return PartialView("_kategorilerPartialPage1");
        }
        public PartialViewResult KategroileriModelPartialIleGetir()
        {
            List<string> kategoriler = new List<string>()
            {
                "Bilgisayar",
                "Monitör",
                "Mouse",
                "Laptop",
                "Aksesuar"
            };
            return PartialView("_kategorilerPartialPage1",kategoriler);
        }
        public FileResult PdfDosyaİndir()
        {
            string dosyaYolu = Server.MapPath("/Yusuf_Aras-cv.pdf");

            return new FilePathResult(dosyaYolu,"application/pdf");
        }
        public FileResult MetinDosyasiİndir()
        {
            string metin = "File Stream Result ile metin dosyası indir";
            MemoryStream memory= new MemoryStream();
            
            byte[] bytes=Encoding.UTF8.GetBytes(metin);

            memory.Write(bytes,0, bytes.Length);
            memory.Position = 0;

            FileStreamResult result = new FileStreamResult(memory, "text/plain");

            result.FileDownloadName = "deneme.txt";

            return result;
        }

        public JavaScriptResult JsResult()
        {
            string js = "alert('JsResult Çalıştı!')";
            return JavaScript(js);
        }
        public JavaScriptResult JsButtonClick()
        {
            string js = "function button_click(){alert('JsButtonClick Çalıştı!') }";
            return JavaScript(js);
        }
        public JsonResult Index4()
        {
            Kullanici kullanici = new Kullanici()
            {
                Id = 9,
                Ad = "yusuf",
                Soyad = "aras",
                KullaniciAdi = "Admin",
                Sifre = "1234"
            };

            return Json(kullanici,JsonRequestBehavior.AllowGet);
        }
        public ContentResult XmlContentResult() 
        {
            var xml = @"<Kullanicilar>" +
                "<Kullanici>" +
                    "<Id>9</Id>" + 
                    "<Ad>yusuf</Ad>" + 
                    "<Soyad>Aras</Soyad>" +
                    "<Email>null</Email>" + 
                "</Kullanici>"+ 
                "<Kullanici>" + 
                    "<Id>10</Id>" + 
                    "<Ad>kaya</Ad>" + 
                    "<Soyad>kaya</Soyad>" + 
                    "<Email>null</Email>" + 
                    "</Kullanici>"+
                "</Kullanicilar>" + "";

            return Content(xml,"application/xml");  //2. parametre xml çıktısı olduğunu belirtir
        }
    }
}