#pragma checksum "D:\Sudhir_Resume\Sudhir_learn\WebApi\OAuthnet5\Pages\GoogleResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5a8133e4796896d0d5677171e8414c557f1a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OAuthnet5.Pages.Pages_GoogleResponse), @"mvc.1.0.view", @"/Pages/GoogleResponse.cshtml")]
namespace OAuthnet5.Pages
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
#line 1 "D:\Sudhir_Resume\Sudhir_learn\WebApi\OAuthnet5\Pages\_ViewImports.cshtml"
using OAuthnet5;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5a8133e4796896d0d5677171e8414c557f1a82", @"/Pages/GoogleResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9290ab176418e1db097881fddb6c10b527be1cb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GoogleResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"bg-info text-white\">Your Login Details</h1>\r\n\r\n<table class=\"table table-sm table-bordered\">\r\n    <tr><th>Name</th><th>Email</th></tr>\r\n    <tr>\r\n");
#nullable restore
#line 8 "D:\Sudhir_Resume\Sudhir_learn\WebApi\OAuthnet5\Pages\GoogleResponse.cshtml"
         foreach (string info in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 10 "D:\Sudhir_Resume\Sudhir_learn\WebApi\OAuthnet5\Pages\GoogleResponse.cshtml"
           Write(info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 11 "D:\Sudhir_Resume\Sudhir_learn\WebApi\OAuthnet5\Pages\GoogleResponse.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591