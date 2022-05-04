using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Controllers
{
    public class BaseNav : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewFrame()
        {
            return View();
        }

        public IActionResult QuerySolutionChooseFrame()
        {
            return View();
        }
    }
}
