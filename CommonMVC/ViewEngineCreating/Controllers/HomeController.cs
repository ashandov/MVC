using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewEngineCreating.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var controller=RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString();
            return Content($"controller: {controller}  action:{action}");
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}