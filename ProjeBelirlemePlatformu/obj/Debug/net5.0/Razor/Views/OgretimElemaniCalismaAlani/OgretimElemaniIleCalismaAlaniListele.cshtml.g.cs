#pragma checksum "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313dae90709ac0fed9f5194e1518776d74d6146a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OgretimElemaniCalismaAlani_OgretimElemaniIleCalismaAlaniListele), @"mvc.1.0.view", @"/Views/OgretimElemaniCalismaAlani/OgretimElemaniIleCalismaAlaniListele.cshtml")]
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
#line 1 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313dae90709ac0fed9f5194e1518776d74d6146a", @"/Views/OgretimElemaniCalismaAlani/OgretimElemaniIleCalismaAlaniListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea501958a0b4614a2ee87ff1540288ead06018aa", @"/Views/_ViewImports.cshtml")]
    public class Views_OgretimElemaniCalismaAlani_OgretimElemaniIleCalismaAlaniListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OgretimElemaniCalismaAlani>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
  
    ViewData["Title"] = "OgretimElemaniIleCalismaAlaniListele";
    Layout = "~/Views/Shared/OgretimElemaniLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Öğretim Elemanı Çalışma Alanları</h4>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Çalışma Alanı</th>\r\n        <th></th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 17 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 20 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
           Write(item.CalismaAlaniID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 21 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
           Write(item.CalismaAlani.CalismaAlaniTanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 557, "\"", 656, 2);
            WriteAttributeValue("", 564, "/OgretimElemaniCalismaAlani/OgretimElemaniCalismaAlaniSil/", 564, 58, true);
#nullable restore
#line 22 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
WriteAttributeValue("", 622, item.OgretimElemaniCalismaAlaniID, 622, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniCalismaAlani\OgretimElemaniIleCalismaAlaniListele.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/OgretimElemaniCalismaAlani/OgretimElemaniCalismaAlaniEkle\" class=\"btn btn-info\">Yeni Çalışma Alanı Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OgretimElemaniCalismaAlani>> Html { get; private set; }
    }
}
#pragma warning restore 1591