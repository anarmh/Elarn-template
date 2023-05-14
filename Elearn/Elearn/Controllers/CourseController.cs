using Microsoft.AspNetCore.Mvc;

namespace Elearn.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
