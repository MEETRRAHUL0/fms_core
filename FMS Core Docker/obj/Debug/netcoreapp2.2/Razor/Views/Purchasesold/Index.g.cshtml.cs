#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d117af753594fb7fc30463222613f999ada31a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchasesold_Index), @"mvc.1.0.view", @"/Views/Purchasesold/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchasesold/Index.cshtml", typeof(AspNetCore.Views_Purchasesold_Index))]
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
#line 1 "E:\Shree\fms_core Docker\FMS Core Docker\Views\_ViewImports.cshtml"
using FMS_Core;

#line default
#line hidden
#line 2 "E:\Shree\fms_core Docker\FMS Core Docker\Views\_ViewImports.cshtml"
using FMS_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d117af753594fb7fc30463222613f999ada31a", @"/Views/Purchasesold/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchasesold_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.EFModels.TblPurchase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d117af753594fb7fc30463222613f999ada31a4715", async() => {
                BeginContext(153, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 58, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(327, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(362, 52, false);
#line 19 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PartyInvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 48, false);
#line 22 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(518, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(574, 50, false);
#line 25 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PartyInvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(624, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(680, 51, false);
#line 28 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentDueAfter));

#line default
#line hidden
            EndContext();
            BeginContext(731, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(787, 49, false);
#line 31 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReverseCharge));

#line default
#line hidden
            EndContext();
            BeginContext(836, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(892, 42, false);
#line 34 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(934, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(990, 50, false);
#line 37 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1096, 47, false);
#line 40 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OtherCharge));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1199, 56, false);
#line 43 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmountBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1311, 45, false);
#line 46 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaxAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1412, 55, false);
#line 49 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmountAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1523, 44, false);
#line 52 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoundOff));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1623, 46, false);
#line 55 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1725, 48, false);
#line 58 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PurchaseBook));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1829, 44, false);
#line 61 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ScanCopy));

#line default
#line hidden
            EndContext();
            BeginContext(1873, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1929, 51, false);
#line 64 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2036, 55, false);
#line 67 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PartyNameNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2147, 57, false);
#line 70 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentModeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 76 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2322, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(2437, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(2472, 51, false);
#line 82 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PartyInvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(2523, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2579, 47, false);
#line 85 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2626, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2682, 49, false);
#line 88 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PartyInvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2787, 50, false);
#line 91 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentDueAfter));

#line default
#line hidden
            EndContext();
            BeginContext(2837, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2893, 48, false);
#line 94 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReverseCharge));

#line default
#line hidden
            EndContext();
            BeginContext(2941, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2997, 41, false);
#line 97 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(3038, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3094, 49, false);
#line 100 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscountAmount));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3199, 46, false);
#line 103 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OtherCharge));

#line default
#line hidden
            EndContext();
            BeginContext(3245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3301, 55, false);
#line 106 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAmountBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(3356, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3412, 44, false);
#line 109 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaxAmount));

#line default
#line hidden
            EndContext();
            BeginContext(3456, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3512, 54, false);
#line 112 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAmountAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(3566, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3622, 43, false);
#line 115 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoundOff));

#line default
#line hidden
            EndContext();
            BeginContext(3665, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3721, 45, false);
#line 118 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3766, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3822, 47, false);
#line 121 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseBook));

#line default
#line hidden
            EndContext();
            BeginContext(3869, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3925, 43, false);
#line 124 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ScanCopy));

#line default
#line hidden
            EndContext();
            BeginContext(3968, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4024, 50, false);
#line 127 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4074, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4130, 57, false);
#line 130 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PartyNameNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4187, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4243, 59, false);
#line 133 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentModeNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4302, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4357, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d117af753594fb7fc30463222613f999ada31a21819", async() => {
                BeginContext(4402, 4, true);
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
#line 136 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(4410, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4430, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d117af753594fb7fc30463222613f999ada31a24159", async() => {
                BeginContext(4478, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(4489, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4509, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d117af753594fb7fc30463222613f999ada31a26505", async() => {
                BeginContext(4556, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 138 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(4566, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 141 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4605, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS_Core.Models.EFModels.TblPurchase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
