#pragma checksum "D:\Проекты_С#\Quiz\Quiz\Views\Answer\Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "642e1f7e805ff7ae43dfed8aa3cdceb5226a1f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answer_Submit), @"mvc.1.0.view", @"/Views/Answer/Submit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Answer/Submit.cshtml", typeof(AspNetCore.Views_Answer_Submit))]
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
#line 1 "D:\Проекты_С#\Quiz\Quiz\Views\_ViewImports.cshtml"
using Quiz;

#line default
#line hidden
#line 2 "D:\Проекты_С#\Quiz\Quiz\Views\_ViewImports.cshtml"
using Quiz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"642e1f7e805ff7ae43dfed8aa3cdceb5226a1f2f", @"/Views/Answer/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb021b4758eac954204b1038f72c10d0086bfde0", @"/Views/_ViewImports.cshtml")]
    public class Views_Answer_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnswerReport>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Проекты_С#\Quiz\Quiz\Views\Answer\Submit.cshtml"
  
    ViewData["Title"] = "Submit";

#line default
#line hidden
            BeginContext(66, 214, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-4\">\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                <div class=\"gratitude\">\r\n                    <p>");
            EndContext();
            BeginContext(281, 10, false);
#line 13 "D:\Проекты_С#\Quiz\Quiz\Views\Answer\Submit.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(291, 183, true);
            WriteLiteral(", </p>\r\n                    <p>Благодарим Вас за участие</p>\r\n                    <p>в нашей викторине!</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnswerReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
