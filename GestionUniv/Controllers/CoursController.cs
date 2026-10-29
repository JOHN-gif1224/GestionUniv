using Microsoft.AspNetCore.Mvc;

namespace GestionUniv.Controllers
{
    public class CoursController : Controller
    {
        // GET: CoursController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CoursController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CoursController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoursController/Create
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

        // GET: CoursController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CoursController/Edit/5
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

        // GET: CoursController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CoursController/Delete/5
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
