#pragma checksum "C:\Users\premi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5274ca86c295e503d6a5a7266889b8b1c97176c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(WebApplication1.Pages.Home.Views_Home_Index))]
namespace WebApplication1.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\premi\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\premi\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5274ca86c295e503d6a5a7266889b8b1c97176c4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92e01cc1cd7090912f02b11145e3d37a7fa9a726", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\premi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Kişi Formu";

#line default
#line hidden
            BeginContext(75, 146, true);
            WriteLiteral("<div id=\"modal-placeholder\"></div>\r\n\r\n<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal\" data-target=\"#add-contact\" data-url=\"");
            EndContext();
            BeginContext(222, 21, false);
#line 7 "C:\Users\premi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                                                                                       Write(Url.Action("Contact"));

#line default
#line hidden
            EndContext();
            BeginContext(243, 27, true);
            WriteLiteral("\">\r\n    Ekle\r\n</button>\r\n\r\n");
            EndContext();
            BeginContext(271, 40, false);
#line 11 "C:\Users\premi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Table", Model));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
