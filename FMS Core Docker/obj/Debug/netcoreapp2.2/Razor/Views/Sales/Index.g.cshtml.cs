#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f649bb176dfb0bec372873c93d51bc63e9d82ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Index), @"mvc.1.0.view", @"/Views/Sales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sales/Index.cshtml", typeof(AspNetCore.Views_Sales_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f649bb176dfb0bec372873c93d51bc63e9d82ef6", @"/Views/Sales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.EFModels.TblSale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f649bb176dfb0bec372873c93d51bc63e9d82ef64353", async() => {
                BeginContext(149, 10, true);
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
            BeginContext(163, 99, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th></th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(263, 45, false);
#line 17 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceId));

#line default
#line hidden
            EndContext();
            BeginContext(308, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(352, 42, false);
#line 20 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleId));

#line default
#line hidden
            EndContext();
            BeginContext(394, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(438, 47, false);
#line 23 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(485, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(529, 52, false);
#line 26 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(625, 55, false);
#line 29 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherChargeAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(724, 44, false);
#line 32 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(768, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(812, 39, false);
#line 35 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(851, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(895, 54, false);
#line 38 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalValueafterTax));

#line default
#line hidden
            EndContext();
            BeginContext(949, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(993, 44, false);
#line 41 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.RoundOff));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1081, 46, false);
#line 44 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1171, 51, false);
#line 47 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1266, 49, false);
#line 50 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ReverseCharge));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1359, 42, false);
#line 53 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1445, 47, false);
#line 56 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentMode));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1536, 44, false);
#line 59 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 57, true);
            WriteLiteral("\r\n        </th>\r\n\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1669, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1705, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f649bb176dfb0bec372873c93d51bc63e9d82ef612031", async() => {
                BeginContext(1754, 37, true);
                WriteLiteral("<i class=\"fa fa-pencil-square-o\"></i>");
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
#line 68 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
                                   WriteLiteral(item.SaleId);

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
            BeginContext(1795, 18, true);
            WriteLiteral(" \r\n             \r\n");
            EndContext();
            BeginContext(1892, 41, true);
            WriteLiteral("        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1933, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f649bb176dfb0bec372873c93d51bc63e9d82ef614546", async() => {
                BeginContext(1985, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2004, 44, false);
#line 74 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceId));

#line default
#line hidden
                EndContext();
                BeginContext(2048, 14, true);
                WriteLiteral("\r\n            ");
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
#line 73 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
                                      WriteLiteral(item.SaleId);

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
            BeginContext(2066, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2110, 41, false);
#line 78 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.SaleId));

#line default
#line hidden
            EndContext();
            BeginContext(2151, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2195, 46, false);
#line 81 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.InvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2285, 51, false);
#line 84 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.DiscountAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(2336, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2380, 54, false);
#line 87 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.OtherChargeAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2478, 43, false);
#line 90 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2565, 38, false);
#line 93 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Tax));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2647, 53, false);
#line 96 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalValueafterTax));

#line default
#line hidden
            EndContext();
            BeginContext(2700, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2744, 43, false);
#line 99 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.RoundOff));

#line default
#line hidden
            EndContext();
            BeginContext(2787, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2831, 45, false);
#line 102 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2876, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2920, 50, false);
#line 105 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(2970, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3014, 48, false);
#line 108 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ReverseCharge));

#line default
#line hidden
            EndContext();
            BeginContext(3062, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3106, 41, false);
#line 111 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(3147, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3191, 61, false);
#line 114 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.PaymentModeNavigation.Mode));

#line default
#line hidden
            EndContext();
            BeginContext(3252, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3296, 48, false);
#line 117 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Customer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3344, 30, true);
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 121 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3377, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS_Core.Models.EFModels.TblSale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
