﻿using Knowledge.Models;
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
