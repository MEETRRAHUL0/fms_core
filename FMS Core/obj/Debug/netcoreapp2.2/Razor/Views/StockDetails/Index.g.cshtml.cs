#pragma checksum "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3040c5acc2e66eeefa5a1c3c8895ce46937921b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StockDetails_Index), @"mvc.1.0.view", @"/Views/StockDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StockDetails/Index.cshtml", typeof(AspNetCore.Views_StockDetails_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3040c5acc2e66eeefa5a1c3c8895ce46937921b9", @"/Views/StockDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_StockDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.vw_StockDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 94, true);
            WriteLiteral("\r\n<h2>Stock Summary report</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(234, 45, false);
#line 13 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(323, 39, false);
#line 16 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(362, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(406, 48, false);
#line 19 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(454, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(498, 52, false);
#line 22 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemwiseDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(550, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(594, 61, false);
#line 25 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerUnitAfterDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(655, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(699, 55, false);
#line 28 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(754, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(798, 40, false);
#line 31 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SGST));

#line default
#line hidden
            EndContext();
            BeginContext(838, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(882, 40, false);
#line 34 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.CGST));

#line default
#line hidden
            EndContext();
            BeginContext(922, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(966, 40, false);
#line 37 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.IGST));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1050, 39, false);
#line 40 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.GST));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1133, 54, false);
#line 43 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1231, 39, false);
#line 46 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MRP));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1314, 46, false);
#line 49 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.HSN_SAC_NO));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1404, 40, false);
#line 52 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1488, 49, false);
#line 55 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasuringUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1581, 47, false);
#line 58 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacture));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1672, 43, false);
#line 61 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1759, 57, false);
#line 64 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemUniqueDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1860, 45, false);
#line 67 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1949, 46, false);
#line 70 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseID));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(2039, 42, false);
#line 73 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleID));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 39, true);
            WriteLiteral("\r\n        </th>\r\n       \r\n    </tr>\r\n\r\n");
            EndContext();
#line 78 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(2161, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2210, 44, false);
#line 82 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2310, 38, false);
#line 85 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2404, 47, false);
#line 88 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2507, 51, false);
#line 91 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemwiseDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2614, 60, false);
#line 94 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnitAfterDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(2674, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2730, 54, false);
#line 97 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(2784, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2840, 39, false);
#line 100 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SGST));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2935, 39, false);
#line 103 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CGST));

#line default
#line hidden
            EndContext();
            BeginContext(2974, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3030, 39, false);
#line 106 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IGST));

#line default
#line hidden
            EndContext();
            BeginContext(3069, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3125, 38, false);
#line 109 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GST));

#line default
#line hidden
            EndContext();
            BeginContext(3163, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3219, 53, false);
#line 112 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(3272, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3328, 38, false);
#line 115 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MRP));

#line default
#line hidden
            EndContext();
            BeginContext(3366, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3422, 45, false);
#line 118 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HSN_SAC_NO));

#line default
#line hidden
            EndContext();
            BeginContext(3467, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3523, 39, false);
#line 121 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(3562, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3618, 48, false);
#line 124 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MeasuringUnit));

#line default
#line hidden
            EndContext();
            BeginContext(3666, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3722, 46, false);
#line 127 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Manufacture));

#line default
#line hidden
            EndContext();
            BeginContext(3768, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3824, 42, false);
#line 130 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(3866, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3922, 56, false);
#line 133 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemUniqueDescription));

#line default
#line hidden
            EndContext();
            BeginContext(3978, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4034, 44, false);
#line 136 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(4078, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4134, 45, false);
#line 139 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseID));

#line default
#line hidden
            EndContext();
            BeginContext(4179, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4235, 41, false);
#line 142 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SaleID));

#line default
#line hidden
            EndContext();
            BeginContext(4276, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 146 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\StockDetails\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4333, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS_Core.Models.vw_StockDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591