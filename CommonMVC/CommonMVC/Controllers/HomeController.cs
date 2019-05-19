using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommonMVC.Models;
using MobileStore.Utils;
using ActionResult.Utils;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CommonMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        public HomeController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public VirtualFileResult GetVirtual()
        {

            var file_path = Path.Combine("~/Files", "New Text Document.txt");
            return File(file_path, "text/plain", "New Text Document.txt");
        }

        public IActionResult GetFileStream()
        {
            
            string file_path = Path.Combine(_appEnvironment.ContentRootPath, "Files/Anatoly Shandov.pdf");

            FileStream fs = new FileStream(file_path, FileMode.Open);
            string file_type = "application/pdf";

            string file_name = "Anatoly Shandov.pdf";


            return File(fs, file_type, file_name);
        }
        public  IActionResult GetFile()
        {
            string file_path = Path.Combine(_appEnvironment.ContentRootPath, "Files/Anatoly Shandov.pdf");

            string file_type = "application/pdf";

            string file_name = "Anatoly Shandov.pdf";

            return PhysicalFile(file_path, file_type, file_name);
        }
        public IActionResult GetByteFile()
        {
            string file_path = Path.Combine(_appEnvironment.ContentRootPath, "Files/New Text Document.txt");
            byte[] mas = System.IO.File.ReadAllBytes(file_path);

            string file_type = "application/txt";

            string file_name = "New Text Document.txt";

            return File(mas, file_type, file_name);
        }
        public IActionResult OkResult()
        {
            return Ok("Query was succesfully completed!");
        }
        public IActionResult GetSquare(int altitude, int height)
        {
            double square = altitude * height / 2;
            return Content($"Triangle sqaure ={square}");
        }
        public IActionResult GetUser()
        {
            User user = new User { Name = "Jimmy", Age = 43 };
            return Json(user);
        }
        public IActionResult GetVoid()
        {
            return new EmptyResult();
        }
        public HtmlResult GetHtml()
        {
            return new HtmlResult("<h3>Hi ASP.NET 5</h3>");
        }
        public IActionResult Index(int age)
        {
            //if (age < 18)
            //{
            //    return Unauthorized();
            //}
            return Content("Validation successfully completed");
            //return RedirectToAction("Contact", "Home");
        }

        public IActionResult About(string s)
        {
            ViewData["Message"] = "Your application description page.";
            if (String.IsNullOrEmpty(s))
            {
                return BadRequest("Parametrs of the query weren't specified");
            }
            return RedirectToRoute("default", new { controller = "Home", action = "GetSquare", height = 2, altitude = 20 });
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return NotFound("Source wasn't found");
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
