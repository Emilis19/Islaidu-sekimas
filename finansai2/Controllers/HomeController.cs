using finansai2.Models;
using finansai2.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace finansai2.Controllers
{
    public class HomeController : Controller
    {
       private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }



 

    }
}
