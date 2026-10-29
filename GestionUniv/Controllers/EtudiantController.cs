using Microsoft.AspNetCore.Mvc;

namespace GestionUniv.Controllers
{
    public class EtudiantController : Controller
    {
        // GET: EtudiantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EtudiantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EtudiantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EtudiantController/Create
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

        // GET: EtudiantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EtudiantController/Edit/5
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

        // GET: EtudiantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EtudiantController/Delete/5
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
