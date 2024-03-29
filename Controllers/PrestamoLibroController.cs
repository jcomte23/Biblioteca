using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class PrestamoLibroController : Controller
    {
        // GET: PrestamoLibroController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PrestamoLibroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestamoLibroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestamoLibroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestamoLibroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestamoLibroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestamoLibroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestamoLibroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
