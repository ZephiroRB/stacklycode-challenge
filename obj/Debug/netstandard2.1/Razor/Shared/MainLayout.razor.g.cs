#pragma checksum "E:\code\projects\stacklycode-challenge\stacklycode-challenge\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9cd3ce13007cbb73b284f81ca7bb3267e45523"
// <auto-generated/>
#pragma warning disable 1591
namespace stacklycode_challenge.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using stacklycode_challenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\_Imports.razor"
using stacklycode_challenge.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"header_wp\">\r\n    <h1 class=\"header_title\"><a href=\"/\">Github <span>Jobs</span></a></h1>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 8 "E:\code\projects\stacklycode-challenge\stacklycode-challenge\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<div class=\"credits\">\r\n    <p><a href=\"https://github.com/ZephiroRB\" target=\"_blank\" rel=\"noopener noreferrer\">Carlos Montalvo </a>\"DevChallenges.io\"</p>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
