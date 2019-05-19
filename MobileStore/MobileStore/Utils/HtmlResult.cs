using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Utils
{
    public class HtmlResult : IActionResult
    {
        private string _htmlCode;
        public HtmlResult(string htmlCode)
        {
            _htmlCode = htmlCode;
        }
        public async Task ExecuteResultAsync(ActionContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html>";
            fullHtmlCode += "<titke>Main page</title>";
            fullHtmlCode += "<meta charset=utf-8/>";
            fullHtmlCode += "</head>/><body>";
            fullHtmlCode += _htmlCode;
            fullHtmlCode += "</body></html>";
            await context.HttpContext.Response.WriteAsync(fullHtmlCode);
        }
    }
}
