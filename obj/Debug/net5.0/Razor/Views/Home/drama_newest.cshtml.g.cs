#pragma checksum "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "770fc493ec620c81eccf678110d175dd47e82e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_drama_newest), @"mvc.1.0.view", @"/Views/Home/drama_newest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770fc493ec620c81eccf678110d175dd47e82e57", @"/Views/Home/drama_newest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_drama_newest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
  
    ViewData["Title"] = "Drama";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Genre: Drama</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
      
        var movies = Movie
            .GetAllMovies()
            .OrderByDescending(x => x.ReleaseYear);
        
        var count = 0;

        foreach (var movie in movies)
        {
            if (movie.ReleaseYear < 2000)
            {
                count++;     
            }
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <br><p>Number of movies in this list: ");
#nullable restore
#line 23 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
                                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"

        foreach (var item in movies)
        {
            if (item.Genre.Contains("Drama"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 653, "\"", 687, 2);
            WriteAttributeValue("", 660, "/Home/this_movie/", 660, 17, true);
#nullable restore
#line 30 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
WriteAttributeValue("", 677, item.Id, 677, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n                    ");
#nullable restore
#line 31 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
               Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                </ul>\r\n");
#nullable restore
#line 33 "C:\Users\Angel\OneDrive\Dokument\Applied Web Architecture\Labs\Labb 2\lab2-postnordangie-main\Views\Home\drama_newest.cshtml"
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
