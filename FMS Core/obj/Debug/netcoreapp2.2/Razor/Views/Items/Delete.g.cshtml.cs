#pragma checksum "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8986e6243ac96990248af97f3d9f986dcfedfe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Delete), @"mvc.1.0.view", @"/Views/Items/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Delete.cshtml", typeof(AspNetCore.Views_Items_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8986e6243ac96990248af97f3d9f986dcfedfe7", @"/Views/Items/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS_Core.Models.EFModels.TblItems>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8986e6243ac96990248af97f3d9f986dcfedfe75131", async() => {
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
            BeginContext(114, 129, true);
            WriteLiteral("\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n     \r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(244, 40, false);
#line 13 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(284, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(346, 36, false);
#line 16 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(382, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(443, 44, false);
#line 19 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HsnSacNo));

#line default
#line hidden
            EndContext();
            BeginContext(487, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(549, 40, false);
#line 22 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HsnSacNo));

#line default
#line hidden
            EndContext();
            BeginContext(589, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(650, 47, false);
#line 25 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacture));

#line default
#line hidden
            EndContext();
            BeginContext(697, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(759, 43, false);
#line 28 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Manufacture));

#line default
#line hidden
            EndContext();
            BeginContext(802, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(863, 43, false);
#line 31 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(906, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(968, 39, false);
#line 34 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1068, 57, false);
#line 37 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemUniqueDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1187, 53, false);
#line 40 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemUniqueDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1301, 41, false);
#line 43 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1404, 37, false);
#line 46 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1502, 46, false);
#line 49 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UseBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1610, 42, false);
#line 52 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UseBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1713, 46, false);
#line 55 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UseMfgDate));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1821, 42, false);
#line 58 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UseMfgDate));

#line default
#line hidden
            EndContext();
            BeginContext(1863, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1924, 49, false);
#line 61 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UseExpiryDate));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2035, 45, false);
#line 64 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UseExpiryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2141, 51, false);
#line 67 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(2192, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2254, 47, false);
#line 70 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(2301, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2362, 49, false);
#line 73 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GstNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2411, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2473, 48, false);
#line 76 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GstNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2582, 59, false);
#line 79 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MeasuringUnitNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2641, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2703, 71, false);
#line 82 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MeasuringUnitNavigation.MeasurintUnitId));

#line default
#line hidden
            EndContext();
            BeginContext(2774, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2835, 54, false);
#line 85 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplierNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2889, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2951, 53, false);
#line 88 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SupplierNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3004, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3065, 50, false);
#line 91 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3115, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3177, 57, false);
#line 94 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeNavigation.ItemTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(3234, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(3268, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8986e6243ac96990248af97f3d9f986dcfedfe717968", async() => {
                BeginContext(3294, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3304, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8986e6243ac96990248af97f3d9f986dcfedfe718361", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 99 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Delete.cshtml"
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
                BeginContext(3340, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3423, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8986e6243ac96990248af97f3d9f986dcfedfe720249", async() => {
                    BeginContext(3445, 12, true);
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
                BeginContext(3461, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3474, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS_Core.Models.EFModels.TblItems> Html { get; private set; }
    }
}
#pragma warning restore 1591