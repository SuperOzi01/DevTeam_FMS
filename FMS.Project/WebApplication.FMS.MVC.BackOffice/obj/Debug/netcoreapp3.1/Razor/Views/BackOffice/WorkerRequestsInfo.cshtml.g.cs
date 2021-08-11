#pragma checksum "C:\Users\alano\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd0e4dbcd86f119a3be2133f803c751e6abaf3e"
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
#line 1 "C:\Users\alano\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.BackOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alano\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.BackOffice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd0e4dbcd86f119a3be2133f803c751e6abaf3e", @"/Views/BackOffice/WorkerRequestsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f29e9a4fe733c724873993e876a08608cd94e41", @"/Views/_ViewImports.cshtml")]
    public class Views_BackOffice_WorkerRequestsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\alano\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
  
    ViewData["Title"] = "Login BackOffice";
    List<SelectListItem> workersList = new List<SelectListItem>();
    foreach (var item in Model.WorkersList)
    {
        workersList.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.EmployeeID.ToString() });
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold"">Maintenance requests</small></button>

<!-- Demo content -->
<div class=""jumbotron jumbotron-fluid "" style=""border-radius: 25px; background:white;"">
    <div class=""container"">
        <h5 class=""reqestNotext"">Request NO. </h5>
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
                        <th></th>
                   ");
            WriteLiteral("     <td></td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\alano\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\WorkerRequestsInfo.cshtml"
                       Write(Model.RequestInfo.BuildingID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!--  End Table info -->
        <!-- Start Brife Description -->
        <p class="" colorB"">Brife Description </p>
        <p>
     
        </p>
        <!-- End Brife Description -->
        <!-- Select Worker -->
        <div class=""form-group mlr"">
           
        </div>
        <!-- End Select Worker -->
        <!-- Start button -->
        <div class="" text-center"">
            <button type=""submit"" class=""btnSignInCard "" data-toggle=""modal"" data-target=""#loginModalReject"" >Close</button>
        </div>
        <!-- End button -->
    </div>
</div>
<!-- End Demo content -->

<!--  demo PopUp Reject -->
<div class=""modal fade pt-60"" role=""dialog"" id=""loginModalReject"">
    <div class=""modal-dialog"">
        <div class=""modal-content W-300"">
            <div class=""modal-body  text-center"">
                <img class=""imgcheck"" src=""ch");
            WriteLiteral(@"eck_icon.png"">
                <h3 class=""modal-title mbtc"">Thank you</h3>
                <p class=""p-pup"">
                    The request has been closed successfully
                </p>
                <button class=""gotit-btn"">GOT IT</button>
            </div>
        </div>
    </div>
</div>
<!--  End PopUp Reject -->");
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
