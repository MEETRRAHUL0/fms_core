#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9783d57a8d7cffda4cd1aa7d749d74baf378af9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StockExpirydetails_Index), @"mvc.1.0.view", @"/Views/StockExpirydetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StockExpirydetails/Index.cshtml", typeof(AspNetCore.Views_StockExpirydetails_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9783d57a8d7cffda4cd1aa7d749d74baf378af9e", @"/Views/StockExpirydetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_StockExpirydetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.vw_StockExpirydetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 96, true);
            WriteLiteral("\r\n<h2>Stock Expiry report</h2>\r\n\r\n \r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(242, 46, false);
#line 14 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.HSN_SAC_NO));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(332, 44, false);
#line 17 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemType));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(420, 50, false);
#line 20 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasuringUnits));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(514, 44, false);
#line 23 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(602, 49, false);
#line 26 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasuringUnit));

#line default
#line hidden
            EndContext();
            BeginContext(651, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(695, 46, false);
#line 29 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(785, 43, false);
#line 32 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(828, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(872, 45, false);
#line 35 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(917, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(961, 46, false);
#line 38 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseID));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1051, 42, false);
#line 41 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleID));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1137, 45, false);
#line 44 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1226, 39, false);
#line 47 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 41, true);
            WriteLiteral("\r\n        </th>\r\n         \r\n    </tr>\r\n\r\n");
            EndContext();
#line 52 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1338, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1375, 45, false);
#line 55 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.HSN_SAC_NO));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1464, 43, false);
#line 58 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ItemType));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1551, 49, false);
#line 61 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.MeasuringUnits));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1644, 43, false);
#line 64 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1731, 48, false);
#line 67 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.MeasuringUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1823, 45, false);
#line 70 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1912, 42, false);
#line 73 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1998, 44, false);
#line 76 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.StockType));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2086, 45, false);
#line 79 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.PurchaseID));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2175, 41, false);
#line 82 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.SaleID));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2260, 44, false);
#line 85 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2348, 38, false);
#line 88 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 39, true);
            WriteLiteral("\r\n        </td>\r\n         \r\n    </tr>\r\n");
            EndContext();
#line 92 "E:\Shree\fms_core Docker\FMS Core Docker\Views\StockExpirydetails\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2428, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS_Core.Models.vw_StockExpirydetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
