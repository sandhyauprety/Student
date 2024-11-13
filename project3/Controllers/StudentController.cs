using Microsoft.AspNetCore.Mvc;

namespace project3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
