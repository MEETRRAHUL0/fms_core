#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4cb583a707247d27cf46932ed69567695a5a205"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Details), @"mvc.1.0.view", @"/Views/Transactions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transactions/Details.cshtml", typeof(AspNetCore.Views_Transactions_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4cb583a707247d27cf46932ed69567695a5a205", @"/Views/Transactions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS_Core.Models.EFModels.TblTransaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 92, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TblTransaction</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(396, 45, true);
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(442, 43, false);
#line 20 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EntryId));

#line default
#line hidden
            EndContext();
            BeginContext(485, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(549, 39, false);
#line 23 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.EntryId));

#line default
#line hidden
            EndContext();
            BeginContext(588, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(651, 45, false);
#line 26 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EntryDate));

#line default
#line hidden
            EndContext();
            BeginContext(696, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(760, 41, false);
#line 29 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.EntryDate));

#line default
#line hidden
            EndContext();
            BeginContext(801, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(864, 45, false);
#line 32 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EntryType));

#line default
#line hidden
            EndContext();
            BeginContext(909, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(973, 41, false);
#line 35 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.EntryType));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1077, 42, false);
#line 38 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1183, 38, false);
#line 41 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1284, 42, false);
#line 44 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1390, 38, false);
#line 47 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1491, 51, false);
#line 50 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1606, 47, false);
#line 53 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1716, 51, false);
#line 56 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionType));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1831, 47, false);
#line 59 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionType));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1941, 50, false);
#line 62 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionRef));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2055, 46, false);
#line 65 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionRef));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2164, 43, false);
#line 68 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2271, 42, false);
#line 71 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Payment.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2376, 44, false);
#line 74 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Purchase));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2484, 43, false);
#line 77 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Purchase.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2590, 41, false);
#line 80 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sales));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2695, 44, false);
#line 83 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sales.SaleId));

#line default
#line hidden
            EndContext();
            BeginContext(2739, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2802, 42, false);
#line 86 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vendor));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2908, 41, false);
#line 89 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vendor.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2996, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4cb583a707247d27cf46932ed69567695a5a20514421", async() => {
                BeginContext(3042, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Transactions\Details.cshtml"
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
            BeginContext(3050, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3058, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4cb583a707247d27cf46932ed69567695a5a20516738", async() => {
                BeginContext(3080, 12, true);
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
            BeginContext(3096, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS_Core.Models.EFModels.TblTransaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
