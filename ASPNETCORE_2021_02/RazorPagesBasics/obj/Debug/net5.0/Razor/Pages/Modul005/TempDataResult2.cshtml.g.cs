#pragma checksum "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul005\TempDataResult2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227343633d3e9a76d23a89d68cc8f5ed1f7291e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesBasics.Pages.Modul005.Pages_Modul005_TempDataResult2), @"mvc.1.0.razor-page", @"/Pages/Modul005/TempDataResult2.cshtml")]
namespace RazorPagesBasics.Pages.Modul005
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227343633d3e9a76d23a89d68cc8f5ed1f7291e8", @"/Pages/Modul005/TempDataResult2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"699a3a2de309a8d8fd548fa7be1e3a21508daf67", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul005_TempDataResult2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Aktueller Kurs\ASPNETCore_2021_02_22\ASPNETCORE_2021_02\RazorPagesBasics\Pages\Modul005\TempDataResult2.cshtml"
Write(TempData["MyEmail"]);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesBasics.Pages.Modul005.TempDataResult2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBasics.Pages.Modul005.TempDataResult2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBasics.Pages.Modul005.TempDataResult2Model>)PageContext?.ViewData;
        public RazorPagesBasics.Pages.Modul005.TempDataResult2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
