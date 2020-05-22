using MasterASP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterASP.Controllers
{
    public class HomeController : Controller
    {
        private AppDB db = new AppDB();
        public ActionResult Index()
        {
            
            return View(db.Products.ToList());//ส่งข้อมูลตาราง product ไปแสดงที่หน้า home
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}