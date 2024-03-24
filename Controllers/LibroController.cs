using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class LibroController : Controller
    {
        // GET: LibroController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LibroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: LibroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: LibroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
