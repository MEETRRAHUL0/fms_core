#pragma checksum "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13453773d9a96b732f2b1c4d000a63f7776095c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemStocks_Delete), @"mvc.1.0.view", @"/Views/ItemStocks/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemStocks/Delete.cshtml", typeof(AspNetCore.Views_ItemStocks_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13453773d9a96b732f2b1c4d000a63f7776095c8", @"/Views/ItemStocks/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemStocks_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS_Core.Models.EFModels.TblItemStock>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 137, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TblItemStock</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(438, 45, true);
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(484, 45, false);
#line 21 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(529, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(593, 41, false);
#line 24 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(634, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(697, 45, false);
#line 27 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(742, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(806, 41, false);
#line 30 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(847, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(910, 39, false);
#line 33 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(949, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1013, 35, false);
#line 36 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1111, 48, false);
#line 39 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1223, 44, false);
#line 42 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1330, 52, false);
#line 45 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemwiseDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1446, 48, false);
#line 48 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemwiseDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1557, 61, false);
#line 51 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerUnitAfterDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1682, 57, false);
#line 54 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PricePerUnitAfterDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1802, 55, false);
#line 57 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1921, 51, false);
#line 60 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2035, 40, false);
#line 63 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sgst));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2139, 36, false);
#line 66 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sgst));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2238, 40, false);
#line 69 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cgst));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2342, 36, false);
#line 72 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cgst));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2441, 40, false);
#line 75 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Igst));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2545, 36, false);
#line 78 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Igst));

#line default
#line hidden
            EndContext();
            BeginContext(2581, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2644, 39, false);
#line 81 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gst));

#line default
#line hidden
            EndContext();
            BeginContext(2683, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2747, 35, false);
#line 84 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gst));

#line default
#line hidden
            EndContext();
            BeginContext(2782, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2845, 54, false);
#line 87 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(2899, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2963, 50, false);
#line 90 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3076, 39, false);
#line 93 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mrp));

#line default
#line hidden
            EndContext();
            BeginContext(3115, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3179, 35, false);
#line 96 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mrp));

#line default
#line hidden
            EndContext();
            BeginContext(3214, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3277, 51, false);
#line 99 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ManufactureDate));

#line default
#line hidden
            EndContext();
            BeginContext(3328, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3392, 47, false);
#line 102 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ManufactureDate));

#line default
#line hidden
            EndContext();
            BeginContext(3439, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3502, 46, false);
#line 105 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(3548, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3612, 42, false);
#line 108 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(3654, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3717, 43, false);
#line 111 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(3760, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3824, 39, false);
#line 114 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(3863, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3926, 51, false);
#line 117 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(3977, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4041, 47, false);
#line 120 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4088, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4151, 40, false);
#line 123 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
            EndContext();
            BeginContext(4191, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4255, 39, false);
#line 126 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4294, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4363, 44, false);
#line 129 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Purchase));

#line default
#line hidden
            EndContext();
            BeginContext(4407, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4471, 43, false);
#line 132 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Purchase.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4514, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4583, 40, false);
#line 135 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sale));

#line default
#line hidden
            EndContext();
            BeginContext(4623, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4687, 43, false);
#line 138 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sale.SaleId));

#line default
#line hidden
            EndContext();
            BeginContext(4730, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4774, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13453773d9a96b732f2b1c4d000a63f7776095c821188", async() => {
                BeginContext(4800, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4810, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13453773d9a96b732f2b1c4d000a63f7776095c821581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 143 "E:\Shree\fms_core\FMS Core\Views\ItemStocks\Delete.cshtml"
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
                BeginContext(4846, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(4929, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13453773d9a96b732f2b1c4d000a63f7776095c823466", async() => {
                    BeginContext(4951, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4967, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4980, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS_Core.Models.EFModels.TblItemStock> Html { get; private set; }
    }
}
#pragma warning restore 1591
