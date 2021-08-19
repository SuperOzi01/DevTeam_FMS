#pragma checksum "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72860db5ca9623cc67a0cc424f91a2afd74c401d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackOffice_WorkerRequestsInfo), @"mvc.1.0.view", @"/Views/BackOffice/WorkerRequestsInfo.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.BackOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.BackOffice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
using ClassLibrary.FMS.DataModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72860db5ca9623cc67a0cc424f91a2afd74c401d", @"/Views/BackOffice/WorkerRequestsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f29e9a4fe733c724873993e876a08608cd94e41", @"/Views/_ViewImports.cshtml")]
    public class Views_BackOffice_WorkerRequestsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassLibrary.FMS.DataModels.Models.MM_RequestInfo_Model>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
  
    ViewData["Title"] = "Login BackOffice";
    Layout = "_MWLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4 ToggleMedia""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold  text-toggel"">Maintenance requests</small></button>

<!-- Demo content -->
<div class=""jumbotron jumbotron-fluid "" style=""border-radius: 25px; background:white;"">
    <div class=""container"">
        <h5 class=""tableHederText"">Request NO. ");
#nullable restore
#line 15 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
                                          Write(Model.RequestInfo.ServiceRequestID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
        <!-- Start Table info -->
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th scope=""col"">Request Creator</th>
                        <th scope=""col"">Request Issue Date</th>
                        <th scope=""col"">Building No.</th>
                        <th scope=""col""> Service Type</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th>");
#nullable restore
#line 29 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
                       Write(Model.RequestInfo.Request_Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
                       Write(Model.RequestInfo.RequestIssueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
                       Write(Model.RequestInfo.BuildingID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
                       Write(Model.RequestInfo.Specialization_Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!--  End Table info -->
        <!-- Start Brife Description -->
        <p class="" colorDescription"">Brife Description </p>
        <p>
            ");
#nullable restore
#line 41 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
       Write(Model.RequestInfo.ServiceDescribtion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <!-- End Brife Description -->\r\n        <!-- Start button -->\r\n");
#nullable restore
#line 45 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
         using (Html.BeginForm("CloseRequestByWorker", "BackOffice", new ServiceRequestAssignmentModel { RequestID = Model.RequestInfo.ServiceRequestID }, FormMethod.Post))
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\" text-center\">\r\n                <button type = \"submit\" class=\"btnSignInCard \" data-toggle=\"modal\" data-target=\"#loginModalReject\">Handle Request</button>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- End button -->\r\n    </div>\r\n</div>\r\n<!-- End Demo content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassLibrary.FMS.DataModels.Models.MM_RequestInfo_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
