using finansai2.Models;
using finansai2.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace finansai2.Controllers
{
    public class IslaidosController : Controller
    {
        private ApplicationDbContext _context;

        public IslaidosController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new IslaidaFormViewModel()
            {
                Kategorijos = _context.Kategorijos.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
     //   [ValidateAntiForgeryToken]
        public ActionResult Create(IslaidaFormViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                viewModel.Kategorijos = _context.Kategorijos.ToList();
                return View("Create", viewModel);
            }

            var islaida = new Islaida
            {
                IsleidejasId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                KategorijaId = viewModel.Kategorija,
                Suma = viewModel.Suma
            };
            _context.Islaidos.Add(islaida);

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }
    }
}