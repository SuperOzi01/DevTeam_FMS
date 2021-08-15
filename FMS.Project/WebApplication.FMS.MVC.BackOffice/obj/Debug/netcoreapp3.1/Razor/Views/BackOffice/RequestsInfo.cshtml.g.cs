#pragma checksum "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ccbf94367a127098e759232d75fa45ff79dd361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackOffice_RequestsInfo), @"mvc.1.0.view", @"/Views/BackOffice/RequestsInfo.cshtml")]
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
#line 1 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
using ClassLibrary.FMS.DataModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ccbf94367a127098e759232d75fa45ff79dd361", @"/Views/BackOffice/RequestsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f29e9a4fe733c724873993e876a08608cd94e41", @"/Views/_ViewImports.cshtml")]
    public class Views_BackOffice_RequestsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceRequestAssignmentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
  
    ViewData["Title"] = "Login BackOffice";
    List<SelectListItem> workersList = new List<SelectListItem>();
    foreach (var item in ViewBag.WorkersList)
    {
        workersList.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.EmployeeID.ToString() });
    }

    int requestID = ViewBag.RequestInfo.ServiceRequestID;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold"">Maintenance requests</small></button>

<!-- Demo content -->
<div class=""jumbotron jumbotron-fluid "" style=""border-radius: 25px; background:white;"">
    <div class=""container"">
        <h5 class=""reqestNotext"">Request NO. ");
#nullable restore
#line 20 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
                                        Write(ViewBag.RequestInfo.ServiceRequestID);

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
#line 34 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
                       Write(ViewBag.RequestInfo.Request_Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
                       Write(ViewBag.RequestInfo.RequestIssueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
                       Write(ViewBag.RequestInfo.BuildingID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
                       Write(ViewBag.RequestInfo.Specialization_Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <!--  End Table info -->\r\n        <!-- Start Brife Description -->\r\n        <p class=\" colorB\">Brife Description </p>\r\n        <p>\r\n            ");
#nullable restore
#line 46 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
       Write(ViewBag.RequestInfo.ServiceDescribtion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <!-- End Brife Description -->\r\n");
#nullable restore
#line 49 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
         using (Html.BeginForm("RequestInfoClick", "BackOffice", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Select Worker -->\r\n            <div class=\"form-group mlr\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
           Write(Html.DropDownListFor(m => m.EmployeeUsername, workersList, "Select Worker", new { @class = "form-control input", id = "WorkersDropDown" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <!-- End Select Worker -->\r\n");
            WriteLiteral(@"            <!-- Start button -->
            <div class="" text-center"">
                <button type=""submit"" class=""btnSignInCard "" data-toggle=""modal"" data-target=""#loginModalAccept"" name=""BtnValue"" value=""Accept"">Accept</button>
                <button type=""submit"" class=""btnSignInCard "" data-toggle=""modal"" data-target=""#loginModalAccept"" name=""BtnValue"" value=""Reject"">Reject</button>
            </div>
            <!-- End button -->
");
#nullable restore
#line 63 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
       Write(Html.HiddenFor(x => x.RequestID, requestID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
       Write(Html.HiddenFor(bid => bid.BuildingID, 0));

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
       Write(Html.HiddenFor(a => a.MaintenanceWorkerID, 1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\RequestsInfo.cshtml"
                                                          
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>
    </div>
<!-- End Demo content -->


<!--  demo PopUp Accept -->
<div class=""modal fade pt-60"" role=""dialog"" id=""loginModalAccept"">
    <div class=""modal-dialog"">
        <div class=""modal-content W-300"">
            <div class=""modal-body  text-center"">
                <img class=""imgcheck"" src=""check_icon.png"">
                <h3 class=""modal-title mbtc"">Thank you</h3>
                <p class=""p-pup"">
                    The request has been successfully Accept
                </p>
                <button class=""gotit-btn"">GOT IT</button>
            </div>
        </div>
    </div>
</div>
<!--  End PopUp Accept -->
<!--  demo PopUp Reject -->
<div class=""modal fade pt-60"" role=""dialog"" id=""loginModalReject"">
    <div class=""modal-dialog"">
        <div class=""modal-content W-300"">
            <div class=""modal-body  text-center"">
                <img class=""imgcheck"" src=""check_icon.png"">
                <h3 class=""modal-title mbtc"">Thank you</h3>
             ");
            WriteLiteral("   <p class=\"p-pup\">\r\n                    The request has been successfully Reject\r\n                </p>\r\n                <button class=\"gotit-btn\">GOT IT</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--  End PopUp Reject -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceRequestAssignmentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
