#pragma checksum "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\AdminCalismaAlani\CalismaAlaniGuncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a70b4dcfef9d6ad5ee4b9c5d39cec305fd2b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminCalismaAlani_CalismaAlaniGuncelle), @"mvc.1.0.view", @"/Views/AdminCalismaAlani/CalismaAlaniGuncelle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a70b4dcfef9d6ad5ee4b9c5d39cec305fd2b2d", @"/Views/AdminCalismaAlani/CalismaAlaniGuncelle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea501958a0b4614a2ee87ff1540288ead06018aa", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminCalismaAlani_CalismaAlaniGuncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.CalismaAlani>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\AdminCalismaAlani\CalismaAlaniGuncelle.cshtml"
  
    ViewData["Title"] = "CalismaAlaniGuncelle";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1>Çalışma Alanı Güncelleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\AdminCalismaAlani\CalismaAlaniGuncelle.cshtml"
 using (Html.BeginForm("CalismaAlaniGuncelle", "AdminCalismaAlani", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 13 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\AdminCalismaAlani\CalismaAlaniGuncelle.cshtml"
   Write(Html.Label("Çalışma Alanı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\AdminCalismaAlani\CalismaAlaniGuncelle.cshtml"
   Write(Html.TextBoxFor(x => x.CalismaAlaniTanim, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <button class=\"btn btn-success\">Güncelle</button>\r\n    </div>\r\n");
#nullable restore
#line 18 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\AdminCalismaAlani\CalismaAlaniGuncelle.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.CalismaAlani> Html { get; private set; }
    }
}
#pragma warning restore 1591
