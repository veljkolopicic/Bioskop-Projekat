#pragma checksum "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c94900dafb0a20a60c6c3bdcf53bad9fe3fcd793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "G:\VladaPrepravljeno\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp;

#line default
#line hidden
#line 2 "G:\VladaPrepravljeno\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp.Models;

#line default
#line hidden
#line 1 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
using BioskopApp.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94900dafb0a20a60c6c3bdcf53bad9fe3fcd793", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    List<Movie> movies = (ViewData["Movies"] as IEnumerable<Movie>).ToList();
    List<Movie> repertoar = (ViewData["Repertoar"] as List<Movie>);

#line default
#line hidden
            BeginContext(217, 105, true);
            WriteLiteral("<div class=\"col-lg-12 mb-4\">\r\n    <div class=\"card shadow mb-4\">\r\n        <ul id=\"out-of-the-box-demo\">\r\n");
            EndContext();
#line 10 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
         for (int i = 0; i < movies.Count(); i++)
        {

#line default
#line hidden
            BeginContext(384, 28, true);
            WriteLiteral("        <li>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 412, "\"", 433, 2);
            WriteAttributeValue("", 419, "#", 419, 1, true);
#line 13 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 420, movies[i].ID, 420, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 23, true);
            WriteLiteral(">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 457, "\"", 479, 1);
#line 14 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 463, movies[i].Image, 463, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 480, "\"", 501, 1);
#line 14 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 486, movies[i].Name, 486, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 502, "\"", 532, 1);
#line 14 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 510, movies[i].Description, 510, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(533, 60, true);
            WriteLiteral("height=\"580\"width=\"1920\">\r\n            </a>\r\n        </li>\r\n");
            EndContext();
#line 17 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(604, 191, true);
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n    <h1 class=\"h3 mb-2 text-gray-800\" style=\"padding-top: 30px;\">Repertoar filmova</h1>\r\n</div>\r\n");
            EndContext();
#line 24 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
     foreach (var movie in repertoar)
    {

#line default
#line hidden
            BeginContext(841, 65, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-6 mb-4\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 906, "\"", 920, 1);
#line 27 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 911, movie.ID, 911, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(921, 184, true);
            WriteLiteral(">\r\n                <div class=\"card shadow mb-4\">\r\n                    <div class=\"card-header py-3\">\r\n                        <h6 class=\"m-0 font-weight-bold text-primary\">Opis filma ");
            EndContext();
            BeginContext(1106, 10, false);
#line 30 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
                                                                            Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1116, 149, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <img class=\"img-fluid px-3 px-sm-4 mt-3 mb-4\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1265, "\"", 1292, 1);
#line 33 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1271, movie.ImageRepertoar, 1271, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1293, 31, true);
            WriteLiteral("/>\r\n                        <p>");
            EndContext();
            BeginContext(1325, 21, false);
#line 34 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
                      Write(movie.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1346, 116, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 mb-4\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1462, "\"", 1476, 1);
#line 38 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1467, movie.ID, 1467, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1477, 173, true);
            WriteLiteral(">\r\n                <div class=\"card shadow mb-4\">\r\n                    <div class=\"card-header py-3\">\r\n                        <h6 class=\"m-0 font-weight-bold text-primary\">");
            EndContext();
            BeginContext(1651, 10, false);
#line 41 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
                                                                 Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1661, 198, true);
            WriteLiteral(" trejler</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <iframe class=\"img-fluid px-3 px-sm-4 mt-3 mb-4\" style=\"width:100%; min-height:300px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1859, "\"", 1879, 1);
#line 44 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1865, movie.Trailer, 1865, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1880, 212, true);
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 49 "G:\VladaPrepravljeno\BioskopApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2099, 78, true);
            WriteLiteral("</div>\r\n\r\n<script>\r\n    jQuery(\'#out-of-the-box-demo\').slippry();\r\n</script>\r\n");
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
