using System.Data.Entity;
using System.Web.Mvc;
using finansai2.Models;
using System;
using System.Linq;
using finansai2.ViewModels;

namespace finansai2.Controllers
{
    public class PerziuretiController : Controller
    {
        private ApplicationDbContext _context;

        public PerziuretiController()
        {
            _context = new ApplicationDbContext();
        }

       [Authorize]
        public ActionResult Perziureti()
        {
            var viewModel = new PerziuretiFormViewModel()
            {
                Kategorijos = _context.Kategorijos.ToList()
            };
            return View(viewModel);
        }
        

        [Authorize]
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Perziureti(PerziuretiFormViewModel viewModel)
        {
            /* if (!ModelState.IsValid)
             {
                 return View("Perziureti", viewModel);
             }*/

                DateTime fromDate = DateTime.Parse(string.Format(viewModel.dateFrom)).Date;
                DateTime toDate = DateTime.Parse(string.Format(viewModel.dateTo)).Date;


                var islaidos = _context.Islaidos.ToList().Where(g => g.DateTime > fromDate && g.DateTime < toDate && g.KategorijaId == viewModel.Kategorija);

                return View("Perziureti2", islaidos);
        }

 

    }
}