#pragma checksum "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14c4b03ca7f1cfd3012494b960f5ce3466f0a607"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_OgrenciHesapAyarlari), @"mvc.1.0.view", @"/Views/Ogrenci/OgrenciHesapAyarlari.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c4b03ca7f1cfd3012494b960f5ce3466f0a607", @"/Views/Ogrenci/OgrenciHesapAyarlari.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea501958a0b4614a2ee87ff1540288ead06018aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_OgrenciHesapAyarlari : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml"
  
    ViewData["Title"] = "OgrenciHesapAyarlari";
    Layout = "~/Views/Shared/OgrenciLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml"
 using (Html.BeginForm("OgrenciHesapAyarlari", "Ogrenci", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Öğrenci Hesap Ayarları</h4>\r\n                <br />\r\n                ");
#nullable restore
#line 14 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml"
           Write(Html.HiddenFor(x => x.OgrenciID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14c4b03ca7f1cfd3012494b960f5ce3466f0a6074875", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputEmail3\">Mail Adresi</label>\r\n                    ");
#nullable restore
#line 18 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml"
               Write(Html.TextBoxFor(x => x.OgrenciMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputPassword4\">Şifre</label>\r\n                    ");
#nullable restore
#line 22 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml"
               Write(Html.TextBoxFor(x => x.OgrenciSifre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <button type=""submit"" class=""btn btn-gradient-primary mr-2""><i class=""mdi mdi-border-color""></i>    Güncelle</button>
                <a href=""/Ogrenci/Anasayfa"" class=""btn btn-gradient-primary mr-2""><i class=""mdi mdi-close""></i>    Vazgeç</a>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "D:\C# Projeler\ProjeBelirlemePlatformu\ProjeBelirlemePlatformu\Views\Ogrenci\OgrenciHesapAyarlari.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
