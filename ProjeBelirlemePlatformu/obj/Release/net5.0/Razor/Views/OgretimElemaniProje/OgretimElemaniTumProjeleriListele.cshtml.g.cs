#pragma checksum "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565c4f70d94710507c70f7ce44a8d0f5f026510b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OgretimElemaniProje_OgretimElemaniTumProjeleriListele), @"mvc.1.0.view", @"/Views/OgretimElemaniProje/OgretimElemaniTumProjeleriListele.cshtml")]
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
#line 1 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565c4f70d94710507c70f7ce44a8d0f5f026510b", @"/Views/OgretimElemaniProje/OgretimElemaniTumProjeleriListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea501958a0b4614a2ee87ff1540288ead06018aa", @"/Views/_ViewImports.cshtml")]
    public class Views_OgretimElemaniProje_OgretimElemaniTumProjeleriListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Proje>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
  
    ViewData["Title"] = "OgretimElemaniTumProjeleriListele";
    Layout = "~/Views/Shared/OgretimElemaniLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Tüm Projeler</h4>
            <table class=""table table-dark"">
                <thead>
                    <tr>
                        <th> Proje Adı </th>
                        <th> Proje Türü </th>
                        <th> Çalışma Alanı </th>
                        <th> Öğretim Elemanı </th>
                        <th> Öğrenci </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                     foreach (var item in Model)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> ");
#nullable restore
#line 30 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                            Write(item.ProjeAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 31 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                            Write(item.ProjeTur);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 32 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                            Write(item.CalismaAlani.CalismaAlaniTanim);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 33 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                            Write(item.OgretimElemani.OgretimElemaniAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                                                                  Write(item.OgretimElemani.OgretimElemaniSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 34 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                            Write(item.Ogrenci.OgrenciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                                                    Write(item.Ogrenci.OgrenciSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\OgretimElemaniProje\OgretimElemaniTumProjeleriListele.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </tbody>
            </table>
            <br />
            <a href=""/OgretimElemaniProje/OgretimElemaniProjeListele"" class=""btn btn-gradient-primary btn-fw""><i class=""mdi mdi-arrow-left""></i>    Geri Dön</a>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Proje>> Html { get; private set; }
    }
}
#pragma warning restore 1591
