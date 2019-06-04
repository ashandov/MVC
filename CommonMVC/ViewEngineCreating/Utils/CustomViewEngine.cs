using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ViewEngineCreating.Utils
{
    public class CustomViewEngine : IViewEngine
    {
        public ViewEngineResult FindView(ActionContext context, string viewName, bool isMainPage)
        {
            string viewPath = viewPath = $"Views/{viewName}.html"; ;
            if (String.IsNullOrEmpty(viewPath))
            {
                viewPath = $"Views/{context.RouteData.Values["action"]}.html";
            }
            if (File.Exists(viewPath))
            {
                return ViewEngineResult.Found(viewName, new CustomView(viewPath));
            }
            else
            {
                return ViewEngineResult.NotFound(viewName, new string[] { });
            }
        }

        public ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage)
        {
            return ViewEngineResult.NotFound(viewPath, new string[] { });
        }
    }
}
