#pragma checksum "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\Home\_TeacherTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03cef97d3a87440afcd09d83d8b84924e8c64c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__TeacherTable), @"mvc.1.0.view", @"/Views/Home/_TeacherTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_TeacherTable.cshtml", typeof(AspNetCore.Views_Home__TeacherTable))]
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
#line 2 "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e03cef97d3a87440afcd09d83d8b84924e8c64c8", @"/Views/Home/_TeacherTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a7a6705a7e088d85c23eb6114ecbb7d1c5e8d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__TeacherTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentTeacherViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 172, true);
            WriteLiteral("\r\n<h3>Our Teachers</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Class</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
         foreach (var teacher in Model.Teachers)
        {

#line default
#line hidden
            BeginContext(265, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(304, 12, false);
#line 15 "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
               Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(316, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(344, 13, false);
#line 16 "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
               Write(teacher.Class);

#line default
#line hidden
            EndContext();
            BeginContext(357, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 18 "C:\Users\she jong shon\Desktop\etc\projects\lessons\닷넷코어기본편\MyApp\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
        }

#line default
#line hidden
            BeginContext(394, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentTeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
