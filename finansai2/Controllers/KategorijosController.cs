using finansai2.Models;
using finansai2.ViewModels;
using System.Web.Mvc;

namespace finansai2.Controllers
{
    public class KategorijosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public KategorijosController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult AddKategorija()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
      //  [ValidateAntiForgeryToken]
        public ActionResult AddKategorija(KategorijaFormViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                return View("AddKategorija", viewModel);
            }

            //  var name = _context.Kategorijos.Single(k => k.Name == viewModel.Name);
           // var id = _context.Kategorijos.Max(p => p.Id);
            var kategorija = new Kategorija
            { 
                Name = viewModel.Name
            };

            _context.Kategorijos.Add(kategorija);

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}