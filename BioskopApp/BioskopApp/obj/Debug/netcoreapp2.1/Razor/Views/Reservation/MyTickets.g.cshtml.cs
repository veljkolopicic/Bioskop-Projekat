#pragma checksum "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20d6b11f61c07c1836bd9abcaff01ab50e0077e"
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
#line 1 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp;

#line default
#line hidden
#line 2 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20d6b11f61c07c1836bd9abcaff01ab50e0077e", @"/Views/Reservation/MyTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_MyTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BioskopApp.Data.Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(106, 532, true);
            WriteLiteral(@"
<h2>Rezervisane karte</h2>

    <table class=""table"">
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
        </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 32 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(687, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(748, 61, false);
#line 36 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProgramOfEvents.Movie.Name));

#line default
#line hidden
            EndContext();
            BeginContext(809, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 39 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
                      var formateddate = item.ProgramOfEvents.Date.ToString("dd MMMM yyyy");

#line default
#line hidden
            BeginContext(951, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(972, 42, false);
#line 40 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
               Write(Html.DisplayFor(modelItem => formateddate));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 43 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
                      var formateddate2 = item.ProgramOfEvents.Time.ToString("hh:mm tt");

#line default
#line hidden
            BeginContext(1153, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1174, 43, false);
#line 44 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
               Write(Html.DisplayFor(modelItem => formateddate2));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1285, 50, false);
#line 47 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberOfTickets));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1403, 56, false);
#line 50 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProgramOfEvents.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1526, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22a607c649543d18e9fe58951877fa9", async() => {
                BeginContext(1573, 6, true);
                WriteLiteral("Otkaži");
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
#line 53 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1583, 46, true);
            WriteLiteral(" |\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 56 "H:\GIT PROJEKAT BIOSKOP\Bioskop-Projekat\BioskopApp\BioskopApp\Views\Reservation\MyTickets.cshtml"
        }

#line default
#line hidden
            BeginContext(1640, 34, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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