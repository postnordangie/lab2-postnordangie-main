#pragma checksum "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6491a938fa236835d2a7b87e54c3633cd6697e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_this_actor_movies), @"mvc.1.0.view", @"/Views/Home/this_actor_movies.cshtml")]
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
#line 1 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\_ViewImports.cshtml"
using MovieLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\_ViewImports.cshtml"
using MovieLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6491a938fa236835d2a7b87e54c3633cd6697e8", @"/Views/Home/this_actor_movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_this_actor_movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Actor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
  
    ViewData["Title"] = "This actor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>About ");
#nullable restore
#line 8 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        <strong>Name: </strong>");
#nullable restore
#line 10 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
                                           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n        <strong>Birthyear: </strong>");
#nullable restore
#line 11 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
                               Write(Model.BirthYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n        <strong>Movielist</strong> <br>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
         foreach (var movie in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 373, "\"", 408, 2);
            WriteAttributeValue("", 380, "/Home/this_movie/", 380, 17, true);
#nullable restore
#line 16 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
WriteAttributeValue("", 397, movie.Id, 397, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 17 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n            </a>\r\n");
#nullable restore
#line 19 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\this_actor_movies.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Actor> Html { get; private set; }
    }
}
#pragma warning restore 1591
