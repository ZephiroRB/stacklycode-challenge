#pragma checksum "E:\code\projects\stacklycode-challenge\stacklycode-challenge\Shared\Results.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd502b15a589646de946276d50d6873d8508522b"
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
    public partial class Results : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"results_wp\">\r\n    <div class=\"job_wp\">\r\n        <div class=\"job_image\"><a href=\"/details/5633c55d-d005-4bc2-bc81-ff83f1b89cfc\"><img src=\"https://jobs.github.com/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBanVMIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--4a37467bd35b454e6218fdce85e8de60eb103dc7/Future%20Plc%20logo.jpeg\" alt=\"Future Plc\"></a></div>\r\n        <div class=\"job_details\">\r\n            <div class=\"wrapper\">\r\n                <h1>Future Plc</h1>\r\n                <a href=\"/details/5633c55d-d005-4bc2-bc81-ff83f1b89cfc\">Java Developer</a><span>Full Time</span>\r\n            </div>\r\n            <ul class=\"job_details_extras\">\r\n                <li>\r\n                    <svg class=\"svg_icon\" focusable=\"false\" viewBox=\"0 0 24 24\" aria-hidden=\"true\">\r\n                        <path d=\"M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm-1 17.93c-3.95-.49-7-3.85-7-7.93 0-.62.08-1.21.21-1.79L9 15v1c0 1.1.9 2 2 2v1.93zm6.9-2.54c-.26-.81-1-1.39-1.9-1.39h-1v-3c0-.55-.45-1-1-1H8v-2h2c.55 0 1-.45 1-1V7h2c1.1 0 2-.9 2-2v-.41c2.93 1.19 5 4.06 5 7.41 0 2.08-.8 3.97-2.1 5.39z\"></path>\r\n                    </svg>\r\n                    <span>Brno-střed</span>\r\n                </li>\r\n                <li>\r\n                    <svg class=\"svg_icon\" focusable=\"false\" viewBox=\"0 0 24 24\" aria-hidden=\"true\">\r\n                        <path d=\"M11.99 2C6.47 2 2 6.48 2 12s4.47 10 9.99 10C17.52 22 22 17.52 22 12S17.52 2 11.99 2zM12 20c-4.42 0-8-3.58-8-8s3.58-8 8-8 8 3.58 8 8-3.58 8-8 8z\"></path>\r\n                        <path d=\"M12.5 7H11v6l5.25 3.15.75-1.23-4.5-2.67z\"></path>\r\n                    </svg>\r\n                    <span>12 days ago</span>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    \r\n    <div class=\"job_pagination\">\r\n        <div class=\"job_page_pagination\">\r\n            <svg class=\"svg_icon\" focusable=\"false\" viewBox=\"0 0 24 24\" aria-hidden=\"true\">\r\n                <path d=\"M15.41 16.59L10.83 12l4.58-4.59L14 6l-6 6 6 6 1.41-1.41z\"></path>\r\n            </svg>\r\n        </div>\r\n        <div class=\"job_page_pagination\"><span>1</span></div>\r\n        <div class=\"job_page_pagination\"><span>2</span></div>\r\n        <div class=\"job_page_pagination\"><span>3</span></div>\r\n        <div class=\"job_page_pagination\"><span>4</span></div>\r\n        <div class=\"job_page_pagination\"><span>5</span></div>\r\n        <div class=\"job_page_pagination\"><span>6</span></div>\r\n        <div class=\"job_page_pagination\"><span>7</span></div>\r\n        <div class=\"job_page_pagination\"><span>8</span></div>\r\n        <div class=\"job_page_pagination\"><span>9</span></div>\r\n        <div class=\"job_page_pagination active\"><span>10</span></div>\r\n        <div class=\"job_page_pagination disabled\">\r\n            <svg class=\"svg_icon\" focusable=\"false\" viewBox=\"0 0 24 24\" aria-hidden=\"true\">\r\n                <path d=\"M8.59 16.59L13.17 12 8.59 7.41 10 6l6 6-6 6-1.41-1.41z\"></path>\r\n            </svg>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591