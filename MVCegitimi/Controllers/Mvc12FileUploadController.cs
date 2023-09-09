using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCegitimi.Controllers
{
    public class Mvc12FileUploadController : Controller
    {
        // GET: Mvc12FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase dosya)
        {
            if(dosya != null&&dosya.ContentLength>0) 
            {
                var extensions=Path.GetExtension(dosya.FileName);
                if(extensions ==".jpg" || extensions == ".png")
                {
                    /*  var folder = Server.MapPath("/Images");
                      var randomFileName=Path.GetRandomFileName();
                      var fileName=Path.ChangeExtension(randomFileName, ".jpg");

                      var path =Path.Combine(folder, fileName);*/

                    //2.Yöntem yüklenen resim adı ile yükleme

                    var fileName=Path.GetFileName(dosya.FileName);
                    var path = Path.Combine(Server.MapPath("/Images"), fileName);

                    dosya.SaveAs(path);
                    ViewBag.ResimAdi=fileName; 
                }
                else
                {
                    ViewData["message"] = "sadece .jpg veya .png ";
                }
            }
            return View();
        }
    }
}