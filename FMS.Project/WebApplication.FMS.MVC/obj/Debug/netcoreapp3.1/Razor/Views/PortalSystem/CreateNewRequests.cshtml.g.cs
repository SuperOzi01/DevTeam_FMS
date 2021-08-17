#pragma checksum "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31203bfbd7a4cb639f88955de1e504ea9131ebe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortalSystem_CreateNewRequests), @"mvc.1.0.view", @"/Views/PortalSystem/CreateNewRequests.cshtml")]
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
#line 1 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\_ViewImports.cshtml"
using WebApplication.FMS.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
using ClassLibrary.FMS.DataModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31203bfbd7a4cb639f88955de1e504ea9131ebe7", @"/Views/PortalSystem/CreateNewRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09a7c3b1544649ea8fef7eddcf64364e491e96f", @"/Views/_ViewImports.cshtml")]
    public class Views_PortalSystem_CreateNewRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassLibrary.FMS.DataModels.Models.NewServiceRequestModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgcheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/check_icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
  
    ViewData["Title"] = "Login BackOffice";
    List<SelectListItem> ServiceType = new List<SelectListItem>();
    List<SP_GetAllSpecializations_Result> Specializations = ViewBag.ServicesList as List<SP_GetAllSpecializations_Result>;
    int buildingNO = ViewBag.BuildingNumber;
    string username = ViewBag.Username as string;

    foreach (var item in Specializations)
    {
        ServiceType.Add(new SelectListItem { Text = item.SpecializationName , Value = item.SpecializationID.ToString() });
    }


    Model.BuildingID = buildingNO;
    Model.CreatorUsername = username;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    
    <!-- Toggle button -->
    <button id=""sidebarCollapse"" type=""button"" class=""btn btn-light bg-white rounded-pill shadow-sm px-4 mb-4 ToggleMedia""><i class=""fa fa-bars mr-2""></i><small class=""text-uppercase font-weight-bold  text-toggel"">Create New Requests</small></button>

    <!-- Demo content -->
    <div class=""jumbotron jumbotron-fluid "" style=""border-radius: 25px; background:white;"">
        <div class=""container"">
            <h5 class=""tableHederText"" style=""margin-bottom: 20px;"">Create New Request</h5>
");
#nullable restore
#line 30 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
             using (Html.BeginForm("SubmitCreateRequest", "PortalSystem", FormMethod.Post, new { @class = "needs-validation", style = "margin-bottom: 30px;" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
           Write(Html.HiddenFor(x => x.BuildingID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
           Write(Html.HiddenFor(x => x.CreatorUsername));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-row"">
                    <div class=""col-lg-6 mb-2"">
                        <label for=""validationTooltip01"" class=""colorDescription"">Bulding NO.</label>
                        <input type=""text"" disabled=""disabled"" class=""form-control input3"" id=""validationTooltip01""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1840, "\"", 1865, 1);
#nullable restore
#line 37 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
WriteAttributeValue("", 1854, buildingNO, 1854, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-6 mb-2\">\r\n                        <label for=\"validationTooltip02\" class=\"colorDescription\">Malfunction Type</label>\r\n                        ");
#nullable restore
#line 42 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
                   Write(Html.DropDownListFor(x => x.SpecializationID, ServiceType, "Select Service Type", new { @class = "form-control input3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31203bfbd7a4cb639f88955de1e504ea9131ebe78484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 43 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SpecializationID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""mb-3 col-lg-12"" style=""margin-top: 20px;"">
                    <label for=""exampleFormControlTextarea1"" placeholder=""Type Your Description .. "" class=""form-label colorDescription"">Brife Description</label>
                    ");
#nullable restore
#line 50 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
               Write(Html.TextAreaFor(x => x.Describtion, new { @class = "form-control input3", placeholder = "Type Your Description .. ", rows = "3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31203bfbd7a4cb639f88955de1e504ea9131ebe710898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 51 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Describtion);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            <div class=\" text-center\">\r\n                <button type=\"submit\" class=\"btnSignInCard \" data-toggle=\"modal\" data-target=\"#loginModalReject\" value=\"Accept\">Submit</button>\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\zshar\Documents\GitHub\DevTeam_FMS\FMS.Project\WebApplication.FMS.MVC\Views\PortalSystem\CreateNewRequests.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>


<!-- End Demo content -->
<!--  Start PopUp Reject -->
<div class=""modal fade pt-60"" role=""dialog"" id=""loginModalReject"">
    <div class=""modal-dialog"">
        <div class=""modal-content W-300"">
            <div class=""modal-body  text-center"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31203bfbd7a4cb639f88955de1e504ea9131ebe713348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <h3 class=""modal-title mbtc"">Thank you</h3>
                <p class=""p-pup"">
                    The request has been successfully Submitted
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassLibrary.FMS.DataModels.Models.NewServiceRequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
