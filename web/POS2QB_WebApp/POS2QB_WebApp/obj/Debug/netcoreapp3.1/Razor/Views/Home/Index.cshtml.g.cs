#pragma checksum "D:\xampp\htdocs\VVCFilaTools\FilaPOS2QB\web\POS2QB_WebApp\POS2QB_WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df2c3ce8092a558a0342d9ead6cc000a8e85b498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\xampp\htdocs\VVCFilaTools\FilaPOS2QB\web\POS2QB_WebApp\POS2QB_WebApp\Views\_ViewImports.cshtml"
using POS2QB_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\xampp\htdocs\VVCFilaTools\FilaPOS2QB\web\POS2QB_WebApp\POS2QB_WebApp\Views\_ViewImports.cshtml"
using POS2QB_WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2c3ce8092a558a0342d9ead6cc000a8e85b498", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238aa6675441e19d8434deb4335909ac9fd209a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\xampp\htdocs\VVCFilaTools\FilaPOS2QB\web\POS2QB_WebApp\POS2QB_WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Hi there!</h1>
    <p>You're about to upload POS data for Quickbooks. <br/>To proceed, please login with your user name and password.</p>
</div>
<div class=""login-wrapper"">
    <div>
        <div>
            <label>Username</label>
        </div>
        <input type=""text"" class=""form-control""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 403, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-describedby=\"basic-addon1\">\r\n    </div>\r\n    <div>\r\n        <div>\r\n            <label>Password</label>\r\n        </div>\r\n        <input type=\"password\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 595, "\"", 609, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-describedby=\"basic-addon1\">\r\n    </div>\r\n    <div>\r\n        <div>\r\n            <label>Site Branch</label>\r\n        </div>\r\n        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 786, "\"", 800, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-describedby=""basic-addon1"">
    </div>
    <div>
        <hr />
        <button class=""btn btn-block btn-dark"">Sign In</button>
    </div>
    <div class=""forgot-password-section"">
        <a href=""#"" class=""btn btn-block btn-default"">Forgot password?</a>
    </div>
    <div class=""login-notif"">
        If you're having trouble signing in, please contact your System Administrator.
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
