#pragma checksum "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul003\GallerySample2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee47603392f1670e4a64a47d121df783b58268c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesBasics.Pages.Modul003.Pages_Modul003_GallerySample2), @"mvc.1.0.razor-page", @"/Pages/Modul003/GallerySample2.cshtml")]
namespace RazorPagesBasics.Pages.Modul003
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
#line 1 "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\_ViewImports.cshtml"
using RazorPagesBasics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee47603392f1670e4a64a47d121df783b58268c", @"/Pages/Modul003/GallerySample2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"699a3a2de309a8d8fd548fa7be1e3a21508daf67", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul003_GallerySample2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>GallerySample2</h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul003\GallerySample2.cshtml"
     foreach (var item in Model.Bilder)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee47603392f1670e4a64a47d121df783b58268c3432", async() => {
                WriteLiteral("\r\n                <img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 312, "\"", 366, 2);
                WriteAttributeValue("", 318, "/imagegen?img=/", 318, 15, true);
#nullable restore
#line 12 "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul003\GallerySample2.cshtml"
WriteAttributeValue("", 333, System.IO.Path.GetFileName(item), 333, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 228, "~/images/", 228, 9, true);
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul003\GallerySample2.cshtml"
AddHtmlAttributeValue("", 237, System.IO.Path.GetFileName(item), 237, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul003\GallerySample2.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesBasics.Pages.Modul003.GallerySample2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBasics.Pages.Modul003.GallerySample2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBasics.Pages.Modul003.GallerySample2Model>)PageContext?.ViewData;
        public RazorPagesBasics.Pages.Modul003.GallerySample2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
