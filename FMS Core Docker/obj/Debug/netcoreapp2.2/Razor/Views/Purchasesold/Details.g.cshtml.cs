#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1f382920ed7ccdd57301606e3a7a00444cbeef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchasesold_Details), @"mvc.1.0.view", @"/Views/Purchasesold/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchasesold/Details.cshtml", typeof(AspNetCore.Views_Purchasesold_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c1f382920ed7ccdd57301606e3a7a00444cbeef", @"/Views/Purchasesold/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchasesold_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS_Core.Models.EFModels.TblPurchase>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoadItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 89, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TblPurchase</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(390, 45, true);
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(436, 52, false);
#line 20 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PartyInvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(488, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(552, 48, false);
#line 23 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PartyInvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(600, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(663, 48, false);
#line 26 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(711, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(775, 44, false);
#line 29 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(819, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(882, 50, false);
#line 32 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PartyInvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(932, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(996, 46, false);
#line 35 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PartyInvoiceNo));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1105, 51, false);
#line 38 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentDueAfter));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1220, 47, false);
#line 41 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentDueAfter));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1330, 49, false);
#line 44 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReverseCharge));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1443, 45, false);
#line 47 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReverseCharge));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1551, 42, false);
#line 50 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1657, 38, false);
#line 53 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1758, 50, false);
#line 56 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1872, 46, false);
#line 59 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1981, 47, false);
#line 62 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherCharge));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2092, 43, false);
#line 65 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.OtherCharge));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2198, 56, false);
#line 68 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmountBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2318, 52, false);
#line 71 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalAmountBeforeTax));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2433, 45, false);
#line 74 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaxAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2542, 41, false);
#line 77 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaxAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2646, 55, false);
#line 80 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmountAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2765, 51, false);
#line 83 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalAmountAfterTax));

#line default
#line hidden
            EndContext();
            BeginContext(2816, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2879, 44, false);
#line 86 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoundOff));

#line default
#line hidden
            EndContext();
            BeginContext(2923, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2987, 40, false);
#line 89 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoundOff));

#line default
#line hidden
            EndContext();
            BeginContext(3027, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3090, 46, false);
#line 92 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3136, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3200, 42, false);
#line 95 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3305, 48, false);
#line 98 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseBook));

#line default
#line hidden
            EndContext();
            BeginContext(3353, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3417, 44, false);
#line 101 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PurchaseBook));

#line default
#line hidden
            EndContext();
            BeginContext(3461, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3524, 44, false);
#line 104 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScanCopy));

#line default
#line hidden
            EndContext();
            BeginContext(3568, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3632, 40, false);
#line 107 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.ScanCopy));

#line default
#line hidden
            EndContext();
            BeginContext(3672, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3735, 51, false);
#line 110 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(3786, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3850, 47, false);
#line 113 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(3897, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3960, 55, false);
#line 116 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PartyNameNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(4015, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4079, 54, false);
#line 119 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PartyNameNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4133, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4196, 57, false);
#line 122 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentModeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(4253, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4317, 56, false);
#line 125 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentModeNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4373, 65, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div style=\"overflow:auto\">\r\n");
            EndContext();
            BeginContext(4507, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(4511, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c1f382920ed7ccdd57301606e3a7a00444cbeef20178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 131 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model =  Model.TblItemStock.ToList();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4576, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4597, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c1f382920ed7ccdd57301606e3a7a00444cbeef21891", async() => {
                BeginContext(4643, 4, true);
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
#line 134 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Purchasesold\Details.cshtml"
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
            BeginContext(4651, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4659, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c1f382920ed7ccdd57301606e3a7a00444cbeef24209", async() => {
                BeginContext(4681, 12, true);
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
            BeginContext(4697, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS_Core.Models.EFModels.TblPurchase> Html { get; private set; }
    }
}
#pragma warning restore 1591
