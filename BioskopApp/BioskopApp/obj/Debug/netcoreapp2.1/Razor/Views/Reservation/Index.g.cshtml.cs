#pragma checksum "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afa4508a00c2d00b725e78069bb395ddccf1aff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/Index.cshtml", typeof(AspNetCore.Views_Reservation_Index))]
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
#line 1 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp;

#line default
#line hidden
#line 2 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afa4508a00c2d00b725e78069bb395ddccf1aff", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BioskopApp.Data.ProgramOfEvents>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reserve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
  
    ViewData["Title"] = "Rezervacija karata";

#line default
#line hidden
            BeginContext(109, 914, true);
            WriteLiteral(@"<div class=""container-fluid"">

    <!-- Page Heading -->
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Rezervacije</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
            <thead>
            <tr>
                <th>
                    Ime filma
                </th>
                <th>
                    Datum
                </th>
                <th>
                    Vreme
                </th>
                <th>
                    Preostale karte
                </th>
                <th>
                    Cena karte
                </th>
                <th></th>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 38 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1067, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1140, 45, false);
#line 41 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Movie.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 44 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                          var formateddate = item.Date.ToString("dd MMMM yyyy");

#line default
#line hidden
            BeginContext(1323, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1348, 42, false);
#line 45 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => formateddate));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 48 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                          var formateddate2 = item.Time.ToString("hh:mm tt");

#line default
#line hidden
            BeginContext(1525, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1550, 43, false);
#line 49 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => formateddate2));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1673, 42, false);
#line 52 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tickets));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1795, 40, false);
#line 55 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1914, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "827064fb49274add8b493cc00f47e5a4", async() => {
                BeginContext(2001, 249, true);
                WriteLiteral("\r\n                            <span class=\"icon text-white-50\">\r\n                            <i class=\"fas fa-check\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Rezervisi</span>\r\n                        ");
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
#line 58 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
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
            BeginContext(2254, 70, true);
            WriteLiteral("                  \r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 66 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\Reservation\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2339, 76, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BioskopApp.Data.ProgramOfEvents>> Html { get; private set; }
    }
}
#pragma warning restore 1591
