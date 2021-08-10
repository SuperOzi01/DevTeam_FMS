#pragma checksum "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "976d24dd4b8108050894c9c26021299b3697e6f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackOffice_MaintananceManagerRequests), @"mvc.1.0.view", @"/Views/BackOffice/MaintananceManagerRequests.cshtml")]
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
#line 1 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
using ClassLibrary.FMS.DataModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976d24dd4b8108050894c9c26021299b3697e6f6", @"/Views/BackOffice/MaintananceManagerRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f29e9a4fe733c724873993e876a08608cd94e41", @"/Views/_ViewImports.cshtml")]
    public class Views_BackOffice_MaintananceManagerRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaintenanceManagerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/DataTables-1.10.25/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/DataTables-1.10.25/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
  
    ViewData["Title"] = "Login BackOffice";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold"">Maintenance requests</small></button>

<!-- Demo content -->
<!--New Request-->

<div class=""container "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""newtext"">New Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""filterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""n");
            WriteLiteral(@"ewtable"" class=""table cust-datatable dataTable no-footer "">
                        <thead>
                            <tr>
                                <th style=""min-width:50px;"">
                                    Service Request No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Building No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Specialization Type
                                </th>
                                <th style=""min-width:100px;"">
                                    Assigned Worker
                                </th>
                                <th style=""min-width:150px;"">
                                    Request Issue Date
                                </th>
                                <th style=""min-width:150px;"">
                                    Request Informa");
            WriteLiteral("tion\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.OpenRequests)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 57 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 60 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                               Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 63 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 66 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 69 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                               Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary\"><i class=\"fa fa-edit\"> ");
#nullable restore
#line 72 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                                                                 Write(Html.ActionLink("Test","RequestsInfo","BackOffice", new ServiceRequestAssignmentModel {RequestID = item.ServiceRequestID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i> </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!--End New Request-->
<!--Open Request-->

<div class=""container "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""newtext"">Opened Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""filterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""Opentable"" class=""table cust-datatable dataTable no-footer "">
                        <thead>
          ");
            WriteLiteral(@"                  <tr>
                                <th style=""min-width:50px;"">
                                    Service Request No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Building No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Specialization Type
                                </th>
                                <th style=""min-width:100px;"">
                                    Assigned Worker
                                </th>
                                <th style=""min-width:150px;"">
                                    Request Issue Date
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 121 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.ApprovedRequests)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 126 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 129 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 132 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 135 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 138 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    \r\n                                </tr>\r\n");
#nullable restore
#line 142 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!--End Open Request-->
<!--Closed Request-->
<div class=""container "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""newtext"">Closed Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""filterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""Closedtable"" class=""table cust-datatable dataTable no-footer"">
                        <thead>
        ");
            WriteLiteral(@"                    <tr>
                                <th style=""min-width:50px;"">
                                    Service Request No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Building No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Specialization Type
                                </th>
                                <th style=""min-width:100px;"">
                                    Assigned Worker
                                </th>
                                <th style=""min-width:150px;"">
                                    Request Issue Date
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 187 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.ClosedRequests)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 191 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 194 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 197 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 200 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 203 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 206 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!--End Closed Request-->


<!--Canceled Request-->
<div class=""container "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""newtext"">Canceled Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""filterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""Closedtable"" class=""table cust-datatable dataTable no-footer"">
                        <thead>");
            WriteLiteral(@"
                            <tr>
                                <th style=""min-width:50px;"">
                                    Service Request No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Building No.
                                </th>
                                <th style=""min-width:150px;"">
                                    Specialization Type
                                </th>
                                <th style=""min-width:100px;"">
                                    Assigned Worker
                                </th>
                                <th style=""min-width:150px;"">
                                    Request Issue Date
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 253 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.CanceledRequests)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 257 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 260 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 263 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 266 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 269 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 272 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--End Canceled Request-->\r\n<!-- End demo content -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "976d24dd4b8108050894c9c26021299b3697e6f627556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "976d24dd4b8108050894c9c26021299b3697e6f628671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "976d24dd4b8108050894c9c26021299b3697e6f629884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "976d24dd4b8108050894c9c26021299b3697e6f630984", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaintenanceManagerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
