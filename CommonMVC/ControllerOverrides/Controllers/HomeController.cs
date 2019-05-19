using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControllerOverrides.Models;
using Microsoft.AspNetCore.Http;
using ControllerOverrides.Services;

namespace ControllerOverrides.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITimeService _timeService;
        public HomeController(ITimeService timeService)
        {
            _timeService = timeService;
        }
        public void Index()
        {
            string table = "";
            foreach(var headers in Request.Headers)
            {
                table += $"<tr><td>{headers.Key}</td><td>{headers.Value}</td></tr>";
            }
            Response.WriteAsync(String.Format("<table>{0}</table", table));
        }

        public void  About()
        {
            Response.StatusCode = 404;
            Response.WriteAsync("Source wasn't found");
        }

        public string Time()
        {
            return _timeService.Time;
        }
        public string TimeAttr([FromServices]ITimeService timeService)
        {
            return timeService.Time;
        }
        


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
