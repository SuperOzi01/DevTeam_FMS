#pragma checksum "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ccdbd80f62fb2fcf2d56943bda29a7563b75c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackOffice_AdminRegistrationRequests), @"mvc.1.0.view", @"/Views/BackOffice/AdminRegistrationRequests.cshtml")]
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
#line 1 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.BackOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.BackOffice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
using ClassLibrary.FMS.DataModels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
using ClassLibrary.FMS.DataModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ccdbd80f62fb2fcf2d56943bda29a7563b75c2", @"/Views/BackOffice/AdminRegistrationRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f29e9a4fe733c724873993e876a08608cd94e41", @"/Views/_ViewImports.cshtml")]
    public class Views_BackOffice_AdminRegistrationRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClassLibrary.FMS.DataModels.Models.NotActiveUsersOfBuildingModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
  
    ViewData["Title"] = "Login BackOffice";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold"">Registration Requests</small></button>

<!-- Demo content -->
<!-- Box info -->
<div class=""content"">
    <div class=""row "">
");
#nullable restore
#line 17 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
         foreach (NotActiveUsersOfBuildingModel building in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- Bulding Number 1 info -->
            <div class=""col-lg-6 "">
                <div class=""card card-stats"" style=""border-radius: 25px; margin-bottom: 20px;"">
                    <div class=""card-body "">

                        <h5 class=""newtext"" style=""margin-bottom: 20px"">Bulding NO. ");
#nullable restore
#line 24 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                                                                               Write(building.BuildingNumber.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                         foreach (SP_ListOfNotActiveBeneficiaries_Result user in building.BeneficiariesList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"" style=""margin-top: 15px"">
                        <div class=""col-3 col-md-2 "">
                            <div class=""icon-big text-center icon-warning"" style=""font-size: 44px; color:#652572;"">
                                <i class=""fas fa-user-circle""></i>
                            </div>
                        </div>
                        <div class=""col-6 col-md-7"">
                            <h4 class=""opentext card-category"">");
#nullable restore
#line 35 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                                                          Write(user.FirstName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                                                                                     Write(user.LastName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"card-title\">");
#nullable restore
#line 36 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                                             Write(user.Email.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n                        </div>\r\n\r\n                        <div class=\"col-3 col-md-3\">\r\n                            <div class=\"icon-big text-center icon-warning\" style=\"font-size: 33px;  margin-top: 15px;\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                           Write(Html.ActionLink("","AcceptBeneficiary", "BackOffice", new LoginModel { Username = user.Username }, new { @class = "fas fa-check-circle", style = "color:#94C11F;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div> \r\n");
#nullable restore
#line 45 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                </div>\r\n            </div>\r\n            <!--End  Bulding Number 1 info -->\r\n");
#nullable restore
#line 50 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\AdminRegistrationRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n</div>\r\n\r\n<!-- End Box info -->\r\n<!-- End Demo content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClassLibrary.FMS.DataModels.Models.NotActiveUsersOfBuildingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
