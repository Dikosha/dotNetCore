#pragma checksum "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa27d6b6d8dc91e3b93e5a18a95648aaa288b9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Result), @"mvc.1.0.view", @"/Views/Calculator/Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caa27d6b6d8dc91e3b93e5a18a95648aaa288b9c", @"/Views/Calculator/Result.cshtml")]
    public class Views_Calculator_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Sum";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"title is-1\">");
#nullable restore
#line 6 "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml"
                  Write(ViewData["action"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2 class=\"subtitle is-2\">");
#nullable restore
#line 7 "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml"
                     Write(ViewData["firstNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml"
                                              Write(ViewData["mark"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml"
                                                                Write(ViewData["secondNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  = ");
#nullable restore
#line 7 "C:\Users\м1\Desktop\Git\dotNetCore\PracticeTut\PracticeTut\Views\Calculator\Result.cshtml"
                                                                                             Write(ViewData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
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