#pragma checksum "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00aa6012cf14b48780aa8dcae6a8769cf1787b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieList), @"mvc.1.0.view", @"/Views/Home/MovieList.cshtml")]
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
#line 1 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00aa6012cf14b48780aa8dcae6a8769cf1787b7a", @"/Views/Home/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml"
 foreach (Movies m in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Title: ");
#nullable restore
#line 6 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml"
          Write(m.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Genre: ");
#nullable restore
#line 7 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml"
          Write(m.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Year: ");
#nullable restore
#line 8 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml"
         Write(m.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Runtime: ");
#nullable restore
#line 9 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml"
            Write(m.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    </p>\r\n");
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\Maggie\Documents\Grand Circus\Projects\MovieRegistration\MovieRegistration\Views\Home\MovieList.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
