using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Models;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;

        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return $"Thanks, {order.User} for the purchase!";
        }
          public string Hello(int id)
        {
            return $"id={id}";
        }
       
        //[ActionName("GeometrySquare")]
        //public string Square(Geometry geometry)
        //{
        //    return $"Площадь треугольника с основанием {geometry.Altitude} и высотой {geometry.Height} равна {geometry.GetSquare()}";
        //}
        //[HttpPost]
        //public string Square(int altitude,int  height)
        //{
        //    return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {altitude*height/2}";
        //}
        public string SquareGet()
        {
            string altitudeString = Request.Query.FirstOrDefault(p => p.Key == "altitude").Value;
            int altitude = Int32.Parse(altitudeString);
            string heightString = Request.Query.FirstOrDefault(p => p.Key == "height").Value;
            int height = Int32.Parse(heightString);
            double square = altitude * height / 2;
            return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}";
        }
        [HttpPost]
        public string Square()
        {
            string altitudeString = Request.Form.FirstOrDefault(p => p.Key == "altitude").Value;
            int altitude = Int32.Parse(altitudeString);
            string heightString = Request.Form.FirstOrDefault(p => p.Key == "height").Value;
            int height = Int32.Parse(heightString);
            double square = altitude * height / 2;
            return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}";
        }
        public string Sum(int [] nums)
        {
            return $"The sum of the nums is equal: {nums.Sum()}";
        }
        [ActionName("GeometrySum")]
        public string Sum(Geometry[] goem)
        {
            return $"The square of the triangle is equal: {goem.Sum(s=> s.GetSquare())}";
        }
        public HomeController(MobileContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }

      
    }
    public class Geometry
    {
        public int Altitude { get; set; }
        public int Height { get; set; }

        public double GetSquare()
        {
            return Altitude * Height / 2;
        }
    }
}
