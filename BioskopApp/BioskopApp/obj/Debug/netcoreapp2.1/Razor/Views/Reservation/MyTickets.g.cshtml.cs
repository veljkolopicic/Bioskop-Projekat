#pragma checksum "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351800e29da5a3cb4061e69d26ab6a28eab95c0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_MyTickets), @"mvc.1.0.view", @"/Views/Reservation/MyTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/MyTickets.cshtml", typeof(AspNetCore.Views_Reservation_MyTickets))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351800e29da5a3cb4061e69d26ab6a28eab95c0b", @"/Views/Reservation/MyTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_MyTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BioskopApp.Data.Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(106, 1089, true);
            WriteLiteral(@"<div class=""container-fluid"">

    <!-- Page Heading -->
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Rezervisane karte</h6>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                <tr>
                    <th>
                        Ime filma
                    </th>
                    <th>
                        Datum projekcije
                    </th>
                    <th>
                        Vreme projekcije
                    </th>
                    <th>
                        Ukupan broj rezervisanih karata
                    </th>
                    <th>
                        Cena pojedinačne karte
                    </th>
                    <th></th>
         ");
            WriteLiteral("       </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 40 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1260, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1345, 61, false);
#line 44 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProgramOfEvents.Movie.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 47 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                              var formateddate = item.ProgramOfEvents.Date.ToString("dd MMMM yyyy");

#line default
#line hidden
            BeginContext(1572, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1601, 42, false);
#line 48 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                       Write(Html.DisplayFor(modelItem => formateddate));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 51 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                              var formateddate2 = item.ProgramOfEvents.Time.ToString("hh:mm tt");

#line default
#line hidden
            BeginContext(1806, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1835, 43, false);
#line 52 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                       Write(Html.DisplayFor(modelItem => formateddate2));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1970, 50, false);
#line 55 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NumberOfTickets));

#line default
#line hidden
            EndContext();
            BeginContext(2020, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2112, 56, false);
#line 58 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProgramOfEvents.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2259, 355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a746de4500884f5d939582fa2a35239a", async() => {
                BeginContext(2344, 266, true);
                WriteLiteral(@"
                                <span class=""icon text-white-50"">
                                <i class=""fas fa-trash""></i>
                                </span>
                                <span class=""text"">Otkaži</span>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                                                     WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2614, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 69 "G:\VladaPrepravljeno\BioskopApp\Views\Reservation\MyTickets.cshtml"
                }

#line default
#line hidden
            BeginContext(2693, 102, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n    </div></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BioskopApp.Data.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
