#pragma checksum "E:\Shree\fms_core Docker\FMS Core Docker\Views\Shared\_Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ddcbb4d390f15e36e53ff97744cf5dcdfe5ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Menu), @"mvc.1.0.view", @"/Views/Shared/_Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Menu.cshtml", typeof(AspNetCore.Views_Shared__Menu))]
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
#line 1 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Shared\_Menu.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ddcbb4d390f15e36e53ff97744cf5dcdfe5ca3", @"/Views/Shared/_Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a42cc394eeaef4029b31c3b2444a2bff0a8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Shared\_Menu.cshtml"
 if (SignInManager.IsSignedIn(User))
{

   

#line default
#line hidden
            BeginContext(188, 33, true);
            WriteLiteral("        <div class=\"col-md-12\">\r\n");
            EndContext();
            BeginContext(271, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(284, 38, false);
#line 12 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Shared\_Menu.cshtml"
       Write(await Component.InvokeAsync("MenuBar"));

#line default
#line hidden
            EndContext();
            BeginContext(322, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 14 "E:\Shree\fms_core Docker\FMS Core Docker\Views\Shared\_Menu.cshtml"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591