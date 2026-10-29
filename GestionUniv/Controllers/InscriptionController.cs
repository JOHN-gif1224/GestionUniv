using Microsoft.AspNetCore.Mvc;

namespace GestionUniv.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: InscriptionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InscriptionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InscriptionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InscriptionController/Create
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

        // GET: InscriptionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InscriptionController/Edit/5
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

        // GET: InscriptionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InscriptionController/Delete/5
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
