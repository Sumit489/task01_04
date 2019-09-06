using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Task01_06.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Image()
        {
            string img = Server.MapPath("~/Content/Image/s.png");
            byte[] bytedata = System.IO.File.ReadAllBytes(img);
            string imgBaseData = Convert.ToBase64String(bytedata);
            string imgurl = string.Format("data:image/png;base64,{0}", imgBaseData);
            ViewBag.ImageData = imgurl;
            return View();
        }
    }
}