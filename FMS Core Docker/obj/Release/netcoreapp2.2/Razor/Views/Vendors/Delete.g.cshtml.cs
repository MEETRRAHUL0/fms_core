#pragma checksum "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbcc9174b94c7edd851892dbad9367f09217a22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Delete), @"mvc.1.0.view", @"/Views/Vendors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Delete.cshtml", typeof(AspNetCore.Views_Vendors_Delete))]
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
#line 1 "E:\Shree\fms_core\FMS Core\Views\_ViewImports.cshtml"
using FMS_Core;

#line default
#line hidden
#line 2 "E:\Shree\fms_core\FMS Core\Views\_ViewImports.cshtml"
using FMS_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbcc9174b94c7edd851892dbad9367f09217a22", @"/Views/Vendors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS_Core.Models.EFModels.TblVendor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0dbcc9174b94c7edd851892dbad9367f09217a225112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(115, 97, true);
            WriteLiteral("\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(423, 45, true);
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(469, 40, false);
#line 20 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(509, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(573, 36, false);
#line 23 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(609, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(672, 49, false);
#line 26 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactPerson));

#line default
#line hidden
            EndContext();
            BeginContext(721, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(785, 45, false);
#line 29 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactPerson));

#line default
#line hidden
            EndContext();
            BeginContext(830, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(893, 45, false);
#line 32 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(938, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1002, 41, false);
#line 35 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1106, 43, false);
#line 38 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1213, 39, false);
#line 41 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1315, 46, false);
#line 44 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorType));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1425, 42, false);
#line 47 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VendorType));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1530, 41, false);
#line 50 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1635, 37, false);
#line 53 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1735, 39, false);
#line 56 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1838, 35, false);
#line 59 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1873, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1936, 41, false);
#line 62 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gstno));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2041, 37, false);
#line 65 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gstno));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2141, 41, false);
#line 68 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tinno));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2246, 37, false);
#line 71 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tinno));

#line default
#line hidden
            EndContext();
            BeginContext(2283, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2346, 41, false);
#line 74 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Panno));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2451, 37, false);
#line 77 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Panno));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2551, 41, false);
#line 80 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cinno));

#line default
#line hidden
            EndContext();
            BeginContext(2592, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2656, 37, false);
#line 83 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cinno));

#line default
#line hidden
            EndContext();
            BeginContext(2693, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2756, 44, false);
#line 86 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdhaarNo));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2864, 40, false);
#line 89 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdhaarNo));

#line default
#line hidden
            EndContext();
            BeginContext(2904, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2967, 50, false);
#line 92 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningBalance));

#line default
#line hidden
            EndContext();
            BeginContext(3017, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3081, 46, false);
#line 95 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpeningBalance));

#line default
#line hidden
            EndContext();
            BeginContext(3127, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3190, 54, false);
#line 98 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningBalanceType));

#line default
#line hidden
            EndContext();
            BeginContext(3244, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3308, 50, false);
#line 101 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpeningBalanceType));

#line default
#line hidden
            EndContext();
            BeginContext(3358, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3421, 54, false);
#line 104 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningBalanceDate));

#line default
#line hidden
            EndContext();
            BeginContext(3475, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3539, 50, false);
#line 107 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpeningBalanceDate));

#line default
#line hidden
            EndContext();
            BeginContext(3589, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3652, 47, false);
#line 110 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(3699, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3763, 43, false);
#line 113 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(3806, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3869, 48, false);
#line 116 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreditPeriod));

#line default
#line hidden
            EndContext();
            BeginContext(3917, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3981, 44, false);
#line 119 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreditPeriod));

#line default
#line hidden
            EndContext();
            BeginContext(4025, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4088, 54, false);
#line 122 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreditInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4142, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4206, 50, false);
#line 125 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreditInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4256, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4319, 53, false);
#line 128 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DebitInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4372, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4436, 49, false);
#line 131 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DebitInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4485, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4548, 51, false);
#line 134 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4599, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4663, 47, false);
#line 137 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4710, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4773, 41, false);
#line 140 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(4814, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4878, 37, false);
#line 143 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(4915, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4978, 42, false);
#line 146 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(5020, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5084, 38, false);
#line 149 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(5122, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5185, 48, false);
#line 152 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyPerson));

#line default
#line hidden
            EndContext();
            BeginContext(5233, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5297, 44, false);
#line 155 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SuretyPerson));

#line default
#line hidden
            EndContext();
            BeginContext(5341, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5404, 57, false);
#line 158 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyPersonContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(5461, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5525, 53, false);
#line 161 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SuretyPersonContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(5578, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5641, 55, false);
#line 164 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyPersonAddress));

#line default
#line hidden
            EndContext();
            BeginContext(5696, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5760, 51, false);
#line 167 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SuretyPersonAddress));

#line default
#line hidden
            EndContext();
            BeginContext(5811, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5874, 50, false);
#line 170 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(5924, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5988, 49, false);
#line 173 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(6037, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(6081, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dbcc9174b94c7edd851892dbad9367f09217a2227541", async() => {
                BeginContext(6107, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6117, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0dbcc9174b94c7edd851892dbad9367f09217a2227934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 178 "E:\Shree\fms_core\FMS Core\Views\Vendors\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(6153, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(6236, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dbcc9174b94c7edd851892dbad9367f09217a2229816", async() => {
                    BeginContext(6258, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6274, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6287, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS_Core.Models.EFModels.TblVendor> Html { get; private set; }
    }
}
#pragma warning restore 1591
