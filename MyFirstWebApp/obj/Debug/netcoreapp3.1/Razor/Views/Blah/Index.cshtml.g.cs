#pragma checksum "C:\Users\chris\Documents\IS413\Mission3\MyFirstWebApp\Views\Blah\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a9996034ffacb1a2fc805c1ecd6261a504ccd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blah_Index), @"mvc.1.0.view", @"/Views/Blah/Index.cshtml")]
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
#line 3 "C:\Users\chris\Documents\IS413\Mission3\MyFirstWebApp\Views\_ViewImports.cshtml"
using MyFirstWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a9996034ffacb1a2fc805c1ecd6261a504ccd9", @"/Views/Blah/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b830daaf248978f15eaad3483a67e86b1ba28e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blah_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!--how to access the razor code in the header and tab title-->\r\n");
#nullable restore
#line 6 "C:\Users\chris\Documents\IS413\Mission3\MyFirstWebApp\Views\Blah\Index.cshtml"
    ViewData["Title"] = "Christian Bennett's Website";
    ViewData["Header"] = "Christian Bennett";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Christian Bennett IS413 -->

<!--image and paragraph about my expectations-->
<img src=""img/astros.jpg"" rotate=""180"" style=""width:500px;height:350px;"" />
<p>I really want to learn how to become better at developing more dynamic web apps. I don't have a lot of experience with C# and I love to learn new programming languages so I am excited to learn the ins and outs of this new language.</p>

<p>My Top Three Jobs:</p>
<ul>
    <li>1. Baseball data analyst</li>
    <li>2. Software Developer for Amazon</li>
    <li>3. Web developer</li>
</ul>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
