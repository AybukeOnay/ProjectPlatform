#pragma checksum "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adaf175502fa6776dd9b6bb49506af448e4003dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BildirimListesi_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BildirimListesi/Default.cshtml")]
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
#line 1 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\_ViewImports.cshtml"
using ProjeBelirlemePlatformu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\_ViewImports.cshtml"
using ProjeBelirlemePlatformu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adaf175502fa6776dd9b6bb49506af448e4003dd", @"/Views/Shared/Components/BildirimListesi/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea501958a0b4614a2ee87ff1540288ead06018aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BildirimListesi_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bildirim>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 5 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <a class=\"dropdown-item preview-item\">\r\n        <div class=\"preview-thumbnail\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 396, "\"", 422, 1);
#nullable restore
#line 10 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
WriteAttributeValue("", 404, item.BildirimRenk, 404, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 444, "\"", 472, 1);
#nullable restore
#line 11 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
WriteAttributeValue("", 452, item.BildirimSembol, 452, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </div>\r\n        </div>\r\n        <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n            <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 15 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
                                                           Write(item.BildirimTur);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 16 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
                                           Write(item.BildirimDetay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 19 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Shared\Components\BildirimListesi\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <h6 class=\"p-3 mb-0 text-center\">Tüm bildirimleri gör</h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bildirim>> Html { get; private set; }
    }
}
#pragma warning restore 1591