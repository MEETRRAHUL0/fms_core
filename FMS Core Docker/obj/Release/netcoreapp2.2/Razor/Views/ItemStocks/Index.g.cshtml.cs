#pragma checksum "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7587cea439bfb3bd52224f50d7d4cac4cb15b41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemStocks_Index), @"mvc.1.0.view", @"/Views/ItemStocks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemStocks/Index.cshtml", typeof(AspNetCore.Views_ItemStocks_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7587cea439bfb3bd52224f50d7d4cac4cb15b41", @"/Views/ItemStocks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemStocks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.EFModels.TblItemStock>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7587cea439bfb3bd52224f50d7d4cac4cb15b414644", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 58, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(328, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(363, 45, false);
#line 19 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 45, false);
#line 22 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(509, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(565, 39, false);
#line 25 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(660, 48, false);
#line 28 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(708, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(764, 52, false);
#line 31 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemwiseDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(816, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(872, 61, false);
#line 34 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerUnitAfterDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(933, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(989, 55, false);
#line 37 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1100, 40, false);
#line 40 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sgst));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1196, 40, false);
#line 43 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cgst));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1292, 40, false);
#line 46 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Igst));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1388, 39, false);
#line 49 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gst));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1483, 54, false);
#line 52 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1593, 39, false);
#line 55 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mrp));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1688, 51, false);
#line 58 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufactureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1795, 46, false);
#line 61 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1897, 43, false);
#line 64 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1996, 51, false);
#line 67 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2103, 40, false);
#line 70 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2199, 44, false);
#line 73 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Purchase));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2299, 40, false);
#line 76 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sale));

#line default
#line hidden
            EndContext();
            BeginContext(2339, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 82 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2457, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(2572, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(2607, 44, false);
#line 88 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(2651, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2707, 44, false);
#line 91 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(2751, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2807, 38, false);
#line 94 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2901, 47, false);
#line 97 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(2948, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3004, 51, false);
#line 100 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemwiseDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3111, 60, false);
#line 103 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnitAfterDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(3171, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3227, 54, false);
#line 106 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(3281, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3337, 39, false);
#line 109 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sgst));

#line default
#line hidden
            EndContext();
            BeginContext(3376, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3432, 39, false);
#line 112 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cgst));

#line default
#line hidden
            EndContext();
            BeginContext(3471, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3527, 39, false);
#line 115 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Igst));

#line default
#line hidden
            EndContext();
            BeginContext(3566, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3622, 38, false);
#line 118 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gst));

#line default
#line hidden
            EndContext();
            BeginContext(3660, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3716, 53, false);
#line 121 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(3769, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3825, 38, false);
#line 124 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mrp));

#line default
#line hidden
            EndContext();
            BeginContext(3863, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3919, 50, false);
#line 127 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManufactureDate));

#line default
#line hidden
            EndContext();
            BeginContext(3969, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4025, 45, false);
#line 130 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(4070, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4126, 42, false);
#line 133 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(4168, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4224, 50, false);
#line 136 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4274, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4330, 42, false);
#line 139 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4372, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4428, 46, false);
#line 142 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Purchase.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4474, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4530, 46, false);
#line 145 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sale.SaleId));

#line default
#line hidden
            EndContext();
            BeginContext(4576, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4631, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7587cea439bfb3bd52224f50d7d4cac4cb15b4122625", async() => {
                BeginContext(4676, 4, true);
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
#line 148 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
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
            BeginContext(4684, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4704, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7587cea439bfb3bd52224f50d7d4cac4cb15b4124949", async() => {
                BeginContext(4752, 7, true);
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
#line 149 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
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
            BeginContext(4763, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4783, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7587cea439bfb3bd52224f50d7d4cac4cb15b4127279", async() => {
                BeginContext(4830, 6, true);
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
#line 150 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
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
            BeginContext(4840, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 153 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4879, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS_Core.Models.EFModels.TblItemStock>> Html { get; private set; }
    }
}
#pragma warning restore 1591
