#pragma checksum "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c766ee412533f522a377e1012666ede9aad9daee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Details), @"mvc.1.0.view", @"/Views/Vendors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Details.cshtml", typeof(AspNetCore.Views_Vendors_Details))]
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
#line 1 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\_ViewImports.cshtml"
using FMS_Core;

#line default
#line hidden
#line 2 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\_ViewImports.cshtml"
using FMS_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c766ee412533f522a377e1012666ede9aad9daee", @"/Views/Vendors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS_Core.Models.EFModels.TblVendor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 18, true);
            WriteLiteral("\r\n \r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(106, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c766ee412533f522a377e1012666ede9aad9daee4472", async() => {
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
            BeginContext(132, 24, true);
            WriteLiteral("\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(367, 45, true);
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(413, 40, false);
#line 19 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(453, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(517, 36, false);
#line 22 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(553, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(616, 49, false);
#line 25 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactPerson));

#line default
#line hidden
            EndContext();
            BeginContext(665, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(729, 45, false);
#line 28 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactPerson));

#line default
#line hidden
            EndContext();
            BeginContext(774, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(837, 45, false);
#line 31 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(882, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(946, 41, false);
#line 34 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(987, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1050, 43, false);
#line 37 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1157, 39, false);
#line 40 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1259, 46, false);
#line 43 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorType));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1369, 42, false);
#line 46 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendorType));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1474, 41, false);
#line 49 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1579, 37, false);
#line 52 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1679, 39, false);
#line 55 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1782, 35, false);
#line 58 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1880, 41, false);
#line 61 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gstno));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1985, 37, false);
#line 64 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gstno));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2085, 41, false);
#line 67 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tinno));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2190, 37, false);
#line 70 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tinno));

#line default
#line hidden
            EndContext();
            BeginContext(2227, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2290, 41, false);
#line 73 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Panno));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2395, 37, false);
#line 76 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Panno));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2495, 41, false);
#line 79 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cinno));

#line default
#line hidden
            EndContext();
            BeginContext(2536, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2600, 37, false);
#line 82 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cinno));

#line default
#line hidden
            EndContext();
            BeginContext(2637, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2700, 44, false);
#line 85 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdhaarNo));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2808, 40, false);
#line 88 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdhaarNo));

#line default
#line hidden
            EndContext();
            BeginContext(2848, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2911, 50, false);
#line 91 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningBalance));

#line default
#line hidden
            EndContext();
            BeginContext(2961, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3025, 46, false);
#line 94 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningBalance));

#line default
#line hidden
            EndContext();
            BeginContext(3071, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3134, 54, false);
#line 97 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningBalanceType));

#line default
#line hidden
            EndContext();
            BeginContext(3188, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3252, 50, false);
#line 100 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningBalanceType));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3365, 54, false);
#line 103 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningBalanceDate));

#line default
#line hidden
            EndContext();
            BeginContext(3419, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3483, 50, false);
#line 106 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningBalanceDate));

#line default
#line hidden
            EndContext();
            BeginContext(3533, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3596, 47, false);
#line 109 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(3643, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3707, 43, false);
#line 112 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(3750, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3813, 48, false);
#line 115 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreditPeriod));

#line default
#line hidden
            EndContext();
            BeginContext(3861, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3925, 44, false);
#line 118 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreditPeriod));

#line default
#line hidden
            EndContext();
            BeginContext(3969, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4032, 54, false);
#line 121 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreditInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4086, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4150, 50, false);
#line 124 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreditInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4200, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4263, 53, false);
#line 127 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DebitInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4316, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4380, 49, false);
#line 130 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.DebitInterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(4429, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4492, 51, false);
#line 133 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4543, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4607, 47, false);
#line 136 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4654, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4717, 41, false);
#line 139 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(4758, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4822, 37, false);
#line 142 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(4859, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4922, 42, false);
#line 145 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(4964, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5028, 38, false);
#line 148 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(5066, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5129, 48, false);
#line 151 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyPerson));

#line default
#line hidden
            EndContext();
            BeginContext(5177, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5241, 44, false);
#line 154 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SuretyPerson));

#line default
#line hidden
            EndContext();
            BeginContext(5285, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5348, 57, false);
#line 157 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyPersonContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(5405, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5469, 53, false);
#line 160 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SuretyPersonContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(5522, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5585, 55, false);
#line 163 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyPersonAddress));

#line default
#line hidden
            EndContext();
            BeginContext(5640, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5704, 51, false);
#line 166 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SuretyPersonAddress));

#line default
#line hidden
            EndContext();
            BeginContext(5755, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5818, 50, false);
#line 169 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(5868, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5932, 49, false);
#line 172 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(5981, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6028, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c766ee412533f522a377e1012666ede9aad9daee27342", async() => {
                BeginContext(6074, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 177 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Vendors\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6082, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6090, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c766ee412533f522a377e1012666ede9aad9daee29650", async() => {
                BeginContext(6112, 12, true);
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
            BeginContext(6128, 10, true);
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
