#pragma checksum "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "187f24303861fcf92f9cf5935eb2156d06ba02cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgramOfEvents_Delete), @"mvc.1.0.view", @"/Views/ProgramOfEvents/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProgramOfEvents/Delete.cshtml", typeof(AspNetCore.Views_ProgramOfEvents_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187f24303861fcf92f9cf5935eb2156d06ba02cf", @"/Views/ProgramOfEvents/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgramOfEvents_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BioskopApp.Data.ProgramOfEvents>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(84, 247, true);
            WriteLiteral("\r\n<h2>Obriši događaj</h2>\r\n\r\n<h3>Da li ste sigurni da želite da obrišete događaj?</h3>\r\n<div>\r\n    <h4>ProgramOfEvents</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Ime filma\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 42, false);
#line 18 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Name));

#line default
#line hidden
            EndContext();
            BeginContext(374, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Datum projekcije\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 24 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
              var formateddate = Model.Date.ToString("dd MMMM yyyy");

#line default
#line hidden
            BeginContext(536, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(549, 42, false);
#line 25 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
       Write(Html.DisplayFor(modelItem => formateddate));

#line default
#line hidden
            EndContext();
            BeginContext(591, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Vreme projekcije\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 31 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
              var formateddate2 = Model.Time.ToString("hh:mm tt");

#line default
#line hidden
            BeginContext(750, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(763, 43, false);
#line 32 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
       Write(Html.DisplayFor(modelItem => formateddate2));

#line default
#line hidden
            EndContext();
            BeginContext(806, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Ukupan broj karata\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(911, 39, false);
#line 38 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tickets));

#line default
#line hidden
            EndContext();
            BeginContext(950, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cena karte\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1047, 37, false);
#line 44 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1122, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5962df8abf23411398f22b9788ddbe0b", async() => {
                BeginContext(1148, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1158, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a858306048ca40dd9d248c9dcf5f5b64", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 49 "G:\VladaPocetno\BioskopApp\BioskopApp\Views\ProgramOfEvents\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1194, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Izbriši\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1279, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb7befdad5f43eba113b1a43c2f7b00", async() => {
                    BeginContext(1301, 23, true);
                    WriteLiteral("Nazad na listu događaja");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1328, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1341, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BioskopApp.Data.ProgramOfEvents> Html { get; private set; }
    }
}
#pragma warning restore 1591
