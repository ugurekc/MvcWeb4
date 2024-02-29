using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb4.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
             ViewBag.list1 = new SelectListItem[]{
             new SelectListItem(){Text="İstanbul", Value="i1"},
             new SelectListItem(){Text="Ankara", Value="a1"},
             new SelectListItem(){Text="İzmir", Value="i2"},
             new SelectListItem(){Text="Antalya", Value="a1"},
             new SelectListItem(){Text="Çanakkale", Value="c1"}
            };

            return View();
        }

        [HttpPost]
        public ActionResult Index(string text1, string check1, string list1)
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
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