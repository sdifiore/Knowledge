using Knowledge.Models;
using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Controllers
{
    public class BaseNav : Controller
    {
        private readonly Repository _repository;

        public BaseNav(Repository repository)
        {
            _repository = repository;
        }

<<<<<<< HEAD
=======
        public IActionResult Index()
        {
            return View();
        }

>>>>>>> 86701c0cbe9b1bf2bacf4ed84cf100a732f97c12
        public IActionResult NewFrame()
        {
            return View();
        }

        public IActionResult QuerySolutionChooseFrame()
        {
            var frameworks = _repository.GetFrameworks();

            return View(frameworks);
        }
    }
}
