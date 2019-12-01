using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Models;
using Domain.Interfaces;
using Infrastructures;

namespace WebApplicationTest_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserInfrastructure ui = new UserInfrastructure();

            return View(ui.GetUsers());
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