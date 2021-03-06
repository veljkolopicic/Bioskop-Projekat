#pragma checksum "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c811d76d48aac517207e0453e22d16fa7142e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_ReservedTickets), @"mvc.1.0.view", @"/Views/Reservation/ReservedTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/ReservedTickets.cshtml", typeof(AspNetCore.Views_Reservation_ReservedTickets))]
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
#line 1 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp;

#line default
#line hidden
#line 2 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\_ViewImports.cshtml"
using BioskopApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c811d76d48aac517207e0453e22d16fa7142e1", @"/Views/Reservation/ReservedTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d085b1c61aa47bd1c1df4c0022f0b4e8aefc7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_ReservedTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<BioskopApp.Data.ProgramOfEvents, BioskopApp.Data.Reservation>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
  
    ViewBag.Title = "Rezervisane karte";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(169, 609, true);
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
              <h5 class=""m-0 font-weight-bold text-primary"">Rezervisane karte</h5>
            </div>
            <div class=""card-body"">
");
            EndContext();
#line 29 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                 foreach (var ev in Model)
                {
                    var formateddate = ev.Key.Date.ToString("dd MMMM yyyy");
                    var formatedTime = ev.Key.Time.ToString("HH:mm tt");


#line default
#line hidden
            BeginContext(995, 65, true);
            WriteLiteral("                    <h6 style=\"font-weight: bold; color: black;\">");
            EndContext();
            BeginContext(1061, 17, false);
#line 34 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                                                            Write(ev.Key.Movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1081, 12, false);
#line 34 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                                                                                Write(formateddate);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1096, 12, false);
#line 34 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                                                                                               Write(formatedTime);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 776, true);
            WriteLiteral(@"</h6>
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>
                                        Korisnik
                                    </th>
                                    <th>
                                        Broj karata
                                    </th>
                                    <th>
                                        Cena pojedinačne karte
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 51 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                             foreach (var res in ev)
                            {

                        

#line default
#line hidden
            BeginContext(1997, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2118, 47, false);
#line 57 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                                   Write(Html.DisplayFor(modelItem => res.User.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2293, 49, false);
#line 60 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                                   Write(Html.DisplayFor(modelItem => res.NumberOfTickets));

#line default
#line hidden
            EndContext();
            BeginContext(2342, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2470, 55, false);
#line 63 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"
                                   Write(Html.DisplayFor(modelItem => res.ProgramOfEvents.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 66 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"

                        
                            }

#line default
#line hidden
            BeginContext(2668, 104, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        </div>\r\n");
            EndContext();
#line 72 "I:\Bioskopprepravljeno\BioskopApp\BioskopApp\Views\Reservation\ReservedTickets.cshtml"

                    }

#line default
#line hidden
            BeginContext(2797, 100, true);
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<BioskopApp.Data.ProgramOfEvents, BioskopApp.Data.Reservation>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
