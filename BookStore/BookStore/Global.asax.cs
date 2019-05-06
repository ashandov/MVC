using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using BookStore.Models;

namespace BookStore
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new BookDBInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
