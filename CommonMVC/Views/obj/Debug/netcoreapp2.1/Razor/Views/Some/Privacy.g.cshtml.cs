#pragma checksum "Z:\Projects\MVC\CommonMVC\Views\Views\Some\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f37e7ac441424cadf33d6c329581b8a13268c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Some_Privacy), @"mvc.1.0.view", @"/Views/Some/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Some/Privacy.cshtml", typeof(AspNetCore.Views_Some_Privacy))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "Z:\Projects\MVC\CommonMVC\Views\Views\_ViewImports.cshtml"
using Views;

#line default
#line hidden
#line 2 "Z:\Projects\MVC\CommonMVC\Views\Views\_ViewImports.cshtml"
using Views.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f37e7ac441424cadf33d6c329581b8a13268c8", @"/Views/Some/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dbabd4896d882914fa112d117d38b482fd9750b", @"/Views/_ViewImports.cshtml")]
    public class Views_Some_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "Z:\Projects\MVC\CommonMVC\Views\Views\Some\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    string head = "Hello world!";

#line default
#line hidden
            BeginContext(82, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(88, 20, true);
            WriteLiteral(" <p> Hi again!</p>\r\n");
            EndContext();
#line 5 "Z:\Projects\MVC\CommonMVC\Views\Views\Some\Privacy.cshtml"
    head += " Welcome on my site";


#line default
#line hidden
            BeginContext(149, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(154, 17, false);
#line 8 "Z:\Projects\MVC\CommonMVC\Views\Views\Some\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(171, 72, true);
            WriteLiteral("</h2>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n<p>");
            EndContext();
            BeginContext(244, 14, true);
            WriteLiteral("@DateTime.Now=");
            EndContext();
            BeginContext(259, 31, false);
#line 11 "Z:\Projects\MVC\CommonMVC\Views\Views\Some\Privacy.cshtml"
             Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(290, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(300, 4, false);
#line 12 "Z:\Projects\MVC\CommonMVC\Views\Views\Some\Privacy.cshtml"
Write(head);

#line default
#line hidden
            EndContext();
            BeginContext(304, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
