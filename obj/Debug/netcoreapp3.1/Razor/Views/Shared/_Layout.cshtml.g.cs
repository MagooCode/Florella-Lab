#pragma checksum "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c330eccb8477c29aa9892ecb834e789dce738583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\_ViewImports.cshtml"
using Fiorella_second;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\_ViewImports.cshtml"
using Fiorella_second.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\_ViewImports.cshtml"
using Fiorella_second.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c330eccb8477c29aa9892ecb834e789dce738583", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c2f13da537fecebca5fea2dc8260613688b8bd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <main role=\"main\" class=\"pb-3\">\r\n        ");
#nullable restore
#line 4 "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </main>\r\n    ");
#nullable restore
#line 6 "C:\Users\magoo\OneDrive\Рабочий стол\Fiorella-Main\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591