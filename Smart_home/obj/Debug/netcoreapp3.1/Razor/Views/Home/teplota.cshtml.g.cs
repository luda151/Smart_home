#pragma checksum "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a20eabc3bb6d421f33ecc1da82c0a2708f51a7f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_teplota), @"mvc.1.0.view", @"/Views/Home/teplota.cshtml")]
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
#line 1 "C:\git\Smart_home\Smart_home\Views\_ViewImports.cshtml"
using Smart_home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\Smart_home\Smart_home\Views\_ViewImports.cshtml"
using Smart_home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20eabc3bb6d421f33ecc1da82c0a2708f51a7f4", @"/Views/Home/teplota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a0c5fc6bda90e2858c6f585cc31ff02c5c6f49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_teplota : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Smart_home.Models.TeplotaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
  
    ViewData["Title"] = "teplota";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>teplota</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Nazev
            </th>
            <th>
                Místnost
            </th>
            <th>
                Aktuální teplota
            </th>
            <th>
                Nastavení teploty
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
           Write(Html.DisplayFor(modelItem => item.NazevTeplomeru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
           Write(Html.DisplayFor(modelItem => item.MistoTeplomeru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
           Write(Html.DisplayFor(modelItem => item.PosledniTeplota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"text\" id=\"fname\" name=\"fname\">\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
           Write(Html.ActionLink("Update", "Update", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 50 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\git\Smart_home\Smart_home\Views\Home\teplota.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Smart_home.Models.TeplotaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591