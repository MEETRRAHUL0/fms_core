#pragma checksum "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e90ea9e8192cc1c7f400bbeb4cd5ec078b49a29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e90ea9e8192cc1c7f400bbeb4cd5ec078b49a29", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS_Core.Models.EFModels.TblItems>>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e90ea9e8192cc1c7f400bbeb4cd5ec078b49a294334", async() => {
                BeginContext(150, 15, true);
                WriteLiteral("Create New Item");
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
            BeginContext(169, 168, true);
            WriteLiteral("\r\n</p>\r\n<div style=\"overflow:auto\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(338, 38, false);
#line 18 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(376, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(444, 40, false);
#line 21 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(484, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(552, 44, false);
#line 24 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HsnSacNo));

#line default
#line hidden
            EndContext();
            BeginContext(596, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(664, 47, false);
#line 27 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Manufacture));

#line default
#line hidden
            EndContext();
            BeginContext(711, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(779, 43, false);
#line 30 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(822, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(890, 57, false);
#line 33 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ItemUniqueDescription));

#line default
#line hidden
            EndContext();
            BeginContext(947, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1015, 41, false);
#line 36 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1124, 46, false);
#line 39 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.UseBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1238, 46, false);
#line 42 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.UseMfgDate));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1352, 49, false);
#line 45 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.UseExpiryDate));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1469, 51, false);
#line 48 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1588, 49, false);
#line 51 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.GstNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1705, 59, false);
#line 54 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MeasuringUnitNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1832, 54, false);
#line 57 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SupplierNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1954, 50, false);
#line 60 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TypeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 81, true);
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 66 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2142, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2214, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e90ea9e8192cc1c7f400bbeb4cd5ec078b49a2912570", async() => {
                BeginContext(2259, 38, true);
                WriteLiteral("<i class=\"fa fa-pencil-square-o\"></i> ");
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
#line 70 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
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
            BeginContext(2301, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
            BeginContext(2391, 77, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2468, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e90ea9e8192cc1c7f400bbeb4cd5ec078b49a2915107", async() => {
                BeginContext(2516, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2547, 37, false);
#line 75 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(2584, 26, true);
                WriteLiteral("\r\n                        ");
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
#line 74 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
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
            BeginContext(2614, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2694, 39, false);
#line 79 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2813, 43, false);
#line 82 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HsnSacNo));

#line default
#line hidden
            EndContext();
            BeginContext(2856, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2936, 46, false);
#line 85 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Manufacture));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3062, 42, false);
#line 88 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3184, 56, false);
#line 91 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ItemUniqueDescription));

#line default
#line hidden
            EndContext();
            BeginContext(3240, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3320, 40, false);
#line 94 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(3360, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3440, 45, false);
#line 97 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UseBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(3485, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3565, 45, false);
#line 100 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UseMfgDate));

#line default
#line hidden
            EndContext();
            BeginContext(3610, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3690, 48, false);
#line 103 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UseExpiryDate));

#line default
#line hidden
            EndContext();
            BeginContext(3738, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3818, 50, false);
#line 106 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(3868, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3948, 53, false);
#line 109 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GstNavigation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4001, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4081, 73, false);
#line 112 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MeasuringUnitNavigation.MeasuringUnits));

#line default
#line hidden
            EndContext();
            BeginContext(4154, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4234, 58, false);
#line 115 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SupplierNavigation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4292, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4372, 58, false);
#line 118 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TypeNavigation.ItemType));

#line default
#line hidden
            EndContext();
            BeginContext(4430, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 122 "E:\Shree\FMS Core\FMS Core\FMS Core\Views\Items\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4499, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS_Core.Models.EFModels.TblItems>> Html { get; private set; }
    }
}
#pragma warning restore 1591