#pragma checksum "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e6c74a0ddb16dadb10777a9c8fdae8400f1720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackOffice_BuildingManagerDashboard), @"mvc.1.0.view", @"/Views/BackOffice/BuildingManagerDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e6c74a0ddb16dadb10777a9c8fdae8400f1720", @"/Views/BackOffice/BuildingManagerDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f29e9a4fe733c724873993e876a08608cd94e41", @"/Views/_ViewImports.cshtml")]
    public class Views_BackOffice_BuildingManagerDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClassLibrary.FMS.DataModels.SP_GetBMOpenedRequests_Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgWorker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/worker illestration.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/plus.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/time-left.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/sign-check-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/DataTables-1.10.25/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTables/DataTables-1.10.25/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
  
    ViewData["Title"] = "Login BackOffice";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Toggle button -->
<button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold"">DASHBOARD</small></button>

<!-- Demo content -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e6c74a0ddb16dadb10777a9c8fdae8400f17208415", async() => {
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
            WriteLiteral("\r\n<div class=\"jumbotron  jumbotron-fluid \" style=\"border-radius: 25px; background:white;\">\r\n    <div class=\"container\">\r\n\r\n        <h1 class=\"helloWorker\">Hello ");
#nullable restore
#line 16 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                 Write(ViewBag.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
        <p>We wish you a happy working day ! </p>
    </div>
</div>
<!-- Box info -->
<div class=""content"">
    <div class=""row "">
        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"" style=""border-radius: 25px; margin-bottom: 20px;"">
                <div class=""card-body "">
                    <div class=""row "">
                        <div class=""col-5 col-md-4 "">
                            <div class=""icon-big text-center icon-warning"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e6c74a0ddb16dadb10777a9c8fdae8400f172010573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""newtext1 card-category"">New Requests</p>
                                <p class=""card-title"">");
#nullable restore
#line 35 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                                 Write(ViewBag.NoNewRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"" style=""border-radius: 25px; margin-bottom: 20px;"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e6c74a0ddb16dadb10777a9c8fdae8400f172012993", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""opentext card-category"">Approved By M.Manager Requests</p>
                                <p class=""card-title"">");
#nullable restore
#line 55 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                                 Write(ViewBag.NoOpenedRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"" style=""border-radius: 25px; margin-bottom: 20px;"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e6c74a0ddb16dadb10777a9c8fdae8400f172015436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">

                            <div class=""numbers"">
                                <p class=""closetext card-category"">Closed Requests</p>
                                <p class=""card-title"">");
#nullable restore
#line 77 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                                 Write(ViewBag.NoClosedRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"" style=""border-radius: 25px; margin-bottom: 20px;"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e6c74a0ddb16dadb10777a9c8fdae8400f172017865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">

                            <div class=""numbers"">
                                <p class=""canseltext card-category"">Canceled Requests</p>
                                <p class=""card-title"">");
#nullable restore
#line 98 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                                 Write(ViewBag.NoCanceledRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>

<!-- End Box info -->
<!--Start New Request-->
<div class=""content "" style="" margin-bottom: 20px;"">
    <div class=""row"">
        <div class=""col-md-12 main-datatable"">
            <div class=""card_body"">
                <div class=""row d-flex"">
                    <h5 class=""newtext"">New Request</h5>
                    <div class=""col-sm-8 add_flex"">
                        <div class=""form-group searchInput"">
                            <label for=""email"">Search:</label>
                            <input type=""search"" class="" form-control"" id=""filterbox"" placeholder="" "">
                        </div>
                    </div>
                </div>
                <div class=""overflow-x"">
                    <table style=""width:100%;"" id=""Newtable"" class=""table cust-datatable dataTable no-footer"">
       ");
            WriteLiteral(@"                 <thead>
                            <tr>
                                <th style=""min-width:150px;"">
                                    Request Number
                                </th>
                                <th style=""min-width:150px;"">
                                    Specialization
                                </th>
                                <th style=""min-width:150px;"">
                                    Request Issue Date 
                                </th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 141 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 145 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ServiceRequestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 148 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Specialization_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 151 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequestIssueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 154 "C:\Users\Rana Alhamdan\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC.BackOffice\Views\BackOffice\BuildingManagerDashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--End New Request-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79e6c74a0ddb16dadb10777a9c8fdae8400f172023839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79e6c74a0ddb16dadb10777a9c8fdae8400f172024954", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e6c74a0ddb16dadb10777a9c8fdae8400f172026167", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e6c74a0ddb16dadb10777a9c8fdae8400f172027268", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClassLibrary.FMS.DataModels.SP_GetBMOpenedRequests_Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
