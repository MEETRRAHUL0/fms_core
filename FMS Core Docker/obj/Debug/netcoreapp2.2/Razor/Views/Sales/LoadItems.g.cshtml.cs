#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c35271fad775d8d3fd8634ebdeac9897cc15c8fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_LoadItems), @"mvc.1.0.view", @"/Views/Sales/LoadItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sales/LoadItems.cshtml", typeof(AspNetCore.Views_Sales_LoadItems))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c35271fad775d8d3fd8634ebdeac9897cc15c8fe", @"/Views/Sales/LoadItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_LoadItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.EFModels.TblItemStock>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 284, true);
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<!-- Add icon library -->
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">


<table class=""table"">
    <tr>
        <th></th>
        <th>
");
            EndContext();
            BeginContext(404, 61, true);
            WriteLiteral("            Sl.No.\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(466, 38, false);
#line 16 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(548, 43, false);
#line 19 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(635, 45, false);
#line 22 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(680, 17, true);
            WriteLiteral("\r\n        </th>\r\n");
            EndContext();
            BeginContext(790, 26, true);
            WriteLiteral("        <th>\r\n            ");
            EndContext();
            BeginContext(817, 45, false);
#line 28 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(862, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(906, 39, false);
#line 31 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(945, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(989, 48, false);
#line 34 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 17, true);
            WriteLiteral("\r\n        </th>\r\n");
            EndContext();
            BeginContext(1259, 26, true);
            WriteLiteral("        <th>\r\n            ");
            EndContext();
            BeginContext(1286, 55, false);
#line 43 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1385, 40, false);
#line 46 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Sgst));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1469, 40, false);
#line 49 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Cgst));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 17, true);
            WriteLiteral("\r\n        </th>\r\n");
            EndContext();
            BeginContext(1614, 26, true);
            WriteLiteral("        <th>\r\n            ");
            EndContext();
            BeginContext(1641, 39, false);
#line 55 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Gst));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1724, 54, false);
#line 58 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1822, 39, false);
#line 61 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Mrp));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1905, 51, false);
#line 64 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.ManufactureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(2000, 46, false);
#line 67 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(2090, 43, false);
#line 70 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(2177, 51, false);
#line 73 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(2228, 19, true);
            WriteLiteral("\r\n        </th>\r\n\r\n");
            EndContext();
            BeginContext(2456, 15, true);
            WriteLiteral("\r\n\r\n    </tr>\r\n");
            EndContext();
#line 85 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
     if (Model != null && Model.Count() > 0)
    {
        var Count = 1;
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2596, 80, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            <button id=\"DeleteItemFromSession\" data-ID=\"");
            EndContext();
            BeginContext(2677, 37, false);
#line 92 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2714, 115, true);
            WriteLiteral("\" class=\"DeleteItemFromSession btn btn-link\">\r\n                <i class=\"fa fa-trash\"></i>\r\n            </button>\r\n");
            EndContext();
            BeginContext(2905, 41, true);
            WriteLiteral("        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2947, 5, false);
#line 98 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Count);

#line default
#line hidden
            EndContext();
            BeginContext(2952, 178, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <button id=\"EditItemFromSession\" class=\"EditItemFromSession btn btn-link\">\r\n                <i class=\"fa fa-pencil-square-o\"></i>&nbsp;");
            EndContext();
            BeginContext(3131, 37, false);
#line 102 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 66, true);
            WriteLiteral("\r\n            </button>\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3235, 42, false);
#line 106 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3277, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3321, 44, false);
#line 109 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3365, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
            BeginContext(3474, 26, true);
            WriteLiteral("        <td>\r\n            ");
            EndContext();
            BeginContext(3501, 44, false);
#line 115 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.InvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(3545, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3589, 38, false);
#line 118 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(3627, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3671, 47, false);
#line 121 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.PricePerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
            BeginContext(3938, 26, true);
            WriteLiteral("        <td>\r\n            ");
            EndContext();
            BeginContext(3965, 54, false);
#line 130 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalPriceBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(4019, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4063, 39, false);
#line 133 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Sgst));

#line default
#line hidden
            EndContext();
            BeginContext(4102, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4146, 39, false);
#line 136 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cgst));

#line default
#line hidden
            EndContext();
            BeginContext(4185, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
            BeginContext(4289, 26, true);
            WriteLiteral("        <td>\r\n            ");
            EndContext();
            BeginContext(4316, 38, false);
#line 142 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Gst));

#line default
#line hidden
            EndContext();
            BeginContext(4354, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4398, 53, false);
#line 145 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalPriceAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(4451, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4495, 38, false);
#line 148 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Mrp));

#line default
#line hidden
            EndContext();
            BeginContext(4533, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4577, 50, false);
#line 151 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.ManufactureDate));

#line default
#line hidden
            EndContext();
            BeginContext(4627, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4671, 45, false);
#line 154 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.Expirydate));

#line default
#line hidden
            EndContext();
            BeginContext(4716, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4760, 42, false);
#line 157 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(4802, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(4846, 50, false);
#line 160 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
       Write(Html.DisplayFor(modelItem => item.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4896, 19, true);
            WriteLiteral("\r\n        </td>\r\n\r\n");
            EndContext();
            BeginContext(5122, 15, true);
            WriteLiteral("\r\n\r\n    </tr>\r\n");
            EndContext();
            BeginContext(5153, 7, false);
#line 173 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
        Write(Count++);

#line default
#line hidden
            EndContext();
#line 173 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
                      
        }

    }
    else
    {

#line default
#line hidden
            BeginContext(5200, 80, true);
            WriteLiteral("        <tr><td colspan=\"4\">No particular found , Please add Item ! </td></tr>\r\n");
            EndContext();
#line 180 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
    }

#line default
#line hidden
            BeginContext(5287, 69, true);
            WriteLiteral("    <tfoot>\r\n        <tr>\r\n            <td colspan=\"4\">No. of Item : ");
            EndContext();
            BeginContext(5358, 34, false);
#line 183 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
                                      Write(Model != null ? Model.Count() : 0 );

#line default
#line hidden
            EndContext();
            BeginContext(5393, 56, true);
            WriteLiteral("</td>\r\n\r\n\r\n            <td colspan=\"3\">Total Quantity : ");
            EndContext();
            BeginContext(5451, 42, false);
#line 186 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Sales\LoadItems.cshtml"
                                         Write(Model != null ? Model.Sum(q => q.Qty) : 0 );

#line default
#line hidden
            EndContext();
            BeginContext(5494, 1052, true);
            WriteLiteral(@"</td>

        </tr>
    </tfoot>
</table>


<script>
    $("".EditItemFromSession"").click(
        function (id) {
            //debugger;
            //LoadEditItemListPopUP(id);

            return false;
        });

    $("".DeleteItemFromSession"").click(
        function (id) {
            debugger;
            var tmp = $(this).attr('data-ID');
            var strURL = '/Purchase/DeleteItemFromSession';
            $.ajax({
                data: { ""ID"": tmp },
                datatype: 'json',
                url: strURL,
                type: 'POST',
                success: function (response) {
                    //debugger;
                    LoadPurchaseItemsView();
                    LoadTotalData(response.total)

                },
                error: function (xhr, ajaxOptions, thrownError) {
                    // debugger;
                    alert(""Error : "" + xhr.responseText + thrownError);

                }

            });
            return fa");
            WriteLiteral("lse;\r\n        });\r\n</script>");
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
