#pragma checksum "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ebd20cf28185aeb0e9cfdec6f26ae26cf4986c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Index.cshtml", typeof(AspNetCore.Views_Movies_Index))]
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
#line 1 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp;

#line default
#line hidden
#line 2 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ebd20cf28185aeb0e9cfdec6f26ae26cf4986c3", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BioskopApp.Data.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 644, true);
            WriteLiteral(@"

  <!-- Page Wrapper -->
  <div id=""wrapper"">

    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

      <!-- Main Content -->
      <div id=""content"">

        <!-- End of Topbar -->

        <!-- Begin Page Content -->
        <div class=""container-fluid"">

          <!-- Page Heading -->
          <!-- DataTales Example -->
          <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
              <h6 class=""m-0 font-weight-bold text-primary"">Repertoar filmova</h6>
            </div>
            <div class=""card-body"">
            <p>
                ");
            EndContext();
            BeginContext(730, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4b541144355432fa0c490e99336e185", async() => {
                BeginContext(792, 197, true);
                WriteLiteral("\r\n                <span class=\"icon text-white-50\">\r\n                    <i class=\"fas fa-check\"></i>\r\n                </span>\r\n                <span class=\"text\">Novi film</span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(993, 401, true);
            WriteLiteral(@"
            </p>
              <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                  <thead>
                    <tr>
                        <th>
                            Naziv
                        </th>
                        <!--
                        <th>
                            ");
            EndContext();
            BeginContext(1395, 41, false);
#line 46 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 115, true);
            WriteLiteral("\r\n                        </th>                        \r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1552, 47, false);
#line 49 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Highlighted));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 571, true);
            WriteLiteral(@"
                        </th>
                        !-->
                        <th>
                            Kratki opis
                        </th>
                        <th>
                            Trejler
                        </th>
                        <th>
                            Opis
                        </th>
                        <th>
                            Slika
                        </th>
                        <th></th>
                    </tr>
                  </thead>
                  <tbody>
");
            EndContext();
#line 68 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2222, 145, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <div class=\"table_content\">\r\n                                ");
            EndContext();
            BeginContext(2368, 39, false);
#line 72 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2407, 214, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <!--\r\n                        <td>\r\n                            <div class=\"table_content\">\r\n                            ");
            EndContext();
            BeginContext(2622, 40, false);
#line 78 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2662, 184, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"table_content\">\r\n                            ");
            EndContext();
            BeginContext(2847, 46, false);
#line 83 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Highlighted));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 214, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        !-->\r\n                        <td>\r\n                            <div class=\"table_content\">\r\n                            ");
            EndContext();
            BeginContext(3108, 46, false);
#line 89 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3154, 198, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"table_content table_trailer\">\r\n                            ");
            EndContext();
            BeginContext(3353, 42, false);
#line 94 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Trailer));

#line default
#line hidden
            EndContext();
            BeginContext(3395, 184, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"table_content\">\r\n                            ");
            EndContext();
            BeginContext(3580, 50, false);
#line 99 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LongDescription));

#line default
#line hidden
            EndContext();
            BeginContext(3630, 204, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"table_content table_image\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3834, "\"", 3890, 1);
#line 104 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
WriteAttributeValue("", 3840, Html.DisplayFor(modelItem => item.ImageRepertoar), 3840, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3891, 130, true);
            WriteLiteral(" />\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4021, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07e518567f14fa59372a5e008a47e9d", async() => {
                BeginContext(4105, 254, true);
                WriteLiteral("\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-check\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Izmena</span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
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
            BeginContext(4363, 84, true);
            WriteLiteral("\r\n                            <div class=\"my-2\"></div>\r\n                            ");
            EndContext();
            BeginContext(4447, 349, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "898a6bd2bbc4460f90a573ff2f2de546", async() => {
                BeginContext(4531, 261, true);
                WriteLiteral(@"
                            <span class=""icon text-white-50"">
                                <i class=""fas fa-info-circle""></i>
                            </span>
                            <span class=""text"">Detalji</span>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 115 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                                                      WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4796, 84, true);
            WriteLiteral("\r\n                            <div class=\"my-2\"></div>\r\n                            ");
            EndContext();
            BeginContext(4880, 345, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e48a12e2a07048b3a525e4f8a57a9a6a", async() => {
                BeginContext(4965, 256, true);
                WriteLiteral(@"
                            <span class=""icon text-white-50"">
                                <i class=""fas fa-trash""></i>
                            </span>
                            <span class=""text"">Brisanje</span>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 122 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
                                                     WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5225, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 130 "F:\DZONI\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5300, 315, true);
            WriteLiteral(@"                  </tbody>
                </table>
              </div>
            </div>
          </div>

        </div>
        <!-- /.container-fluid -->

      </div>
      <!-- End of Main Content -->

    </div>
    <!-- End of Content Wrapper -->

  </div>
  <!-- End of Page Wrapper -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BioskopApp.Data.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
