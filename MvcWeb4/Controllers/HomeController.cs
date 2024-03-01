using MvcWeb4.Models;
using MvcWeb4.ViewModels;
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

            Person psn = new Person();
            psn.name = "Hasan";
            psn.surname = "Kemal";
            psn.age = 80;

            Adress ads = new Adress();
            ads.definition = "132 sok.";
            ads.city = "Kayseri";
            ads.country = "Türkiye";

            HomeViewModel hvm = new HomeViewModel();
            hvm.p1 = psn;
            hvm.a1 = ads;

            return View(hvm);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel hmv)
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