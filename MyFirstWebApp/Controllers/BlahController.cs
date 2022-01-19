using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GradeForm ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GradeForm (GradeFormModel model)
        {
            return View();
        }
    }
}
