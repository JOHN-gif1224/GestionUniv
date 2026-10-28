using Microsoft.AspNetCore.Mvc;

namespace GestionUniv.Controllers
{
    public class StudentsController : Controller
    {
        // GET: StudentsController
        public ActionResult Index()
        {
            return View();
        }

    }
}
