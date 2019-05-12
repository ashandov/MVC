using System;
using Microsoft.AspNetCore.Mvc;

namespace EmtyApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
