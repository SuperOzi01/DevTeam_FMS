#pragma checksum "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bdd62dcb2f10e7e3539ee4905ef6c39ffc6286f"
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
#line 1 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
using ClassLibrary.FMS.DataModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bdd62dcb2f10e7e3539ee4905ef6c39ffc6286f", @"/Views/BackOffice/MaintananceManagerRequests.cshtml")]
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
#line 3 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
  
    ViewData["Title"] = "Login BackOffice";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold"">Maintenance requests</small></button>

<!-- Demo content -->
<!--New Request-->

<div class=""content "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""newtext"">New Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""MaintananceManagerNew2tablefilterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table ");
            WriteLiteral(@"style=""width:100%;"" id=""MaintananceManagerNew2table"" class=""table cust-datatable dataTable no-footer "">
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
       ");
            WriteLiteral("                             Request Information\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.OpenRequests)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 57 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 60 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 63 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 66 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.ActionLink("", "RequestsInfo", "BackOffice", new { RequestNo = item.ServiceRequestID, ServiceType = item.Specialization_Type }, new { @class = "fa fa-edit" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
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
<div class=""content "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""opentext1"">Opened Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""MaintananceManagerOpentablefilterboxfilterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""MaintananceManagerOpentable"" class=""table cust-datatable dataTable ");
            WriteLiteral(@"no-footer "">
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
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 122 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.ApprovedRequests)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 127 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 130 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 133 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 136 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 139 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 142 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
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
<div class=""content "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""closetext1"">Closed Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""MaintananceManagerClosedtablefilterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""MaintananceManagerClosedtable"" class=""table cust-datatable dataTable no-foo");
            WriteLiteral(@"ter"">
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
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 187 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.ClosedRequests)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 191 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 194 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 197 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 200 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 203 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 206 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
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
<div class=""content "" style=""margin-bottom: 30px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""canseltext1"">Canceled Requests</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""MaintananceManagerCanceledtablefilterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""MaintananceManagerCanceledtable"" class=""table cust-datatable dataT");
            WriteLiteral(@"able no-footer"">
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
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 251 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                             foreach (var item in Model.CanceledRequests)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 255 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 258 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BuildingID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 261 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 264 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Assigned_Worker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 267 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 270 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\MaintananceManagerRequests.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--End Canceled Request-->\r\n<!-- End demo content -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdd62dcb2f10e7e3539ee4905ef6c39ffc6286f28016", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bdd62dcb2f10e7e3539ee4905ef6c39ffc6286f29131", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bdd62dcb2f10e7e3539ee4905ef6c39ffc6286f30344", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bdd62dcb2f10e7e3539ee4905ef6c39ffc6286f31444", async() => {
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
                WriteLiteral("\r\n  \r\n");
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
