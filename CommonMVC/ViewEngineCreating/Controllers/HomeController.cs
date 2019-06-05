using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ViewEngineCreating.Controllers
{
    [Route("Store")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route(" ")]
        [Route("homepage")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("{id:int}/{name:maxlength(10)}")]
        [Route("Test")]
        public IActionResult Test(int id,string name)
        {
            return Content($"id: {id}  name:{name}");
        }
        [Route("{name}")]
        public IActionResult About(string name)
        {
            return Content($"name:{name}");
        }
       [Route("[controller]/[action]/{id?}")]
        public IActionResult Contact()
        {
            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString();

            return Content($"controller :{controller} | action: {action}");
        }
    }
}
