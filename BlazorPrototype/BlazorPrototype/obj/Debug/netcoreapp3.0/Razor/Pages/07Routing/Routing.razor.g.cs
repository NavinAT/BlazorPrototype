#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\07Routing\Routing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172d2f37bd713249b8c28ca5cfa47d5570c844fd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPrototype.Pages._07Routing
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using BlazorAppCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\_Imports.razor"
using BlazorPrototype.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/routing")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/routingOne")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/routingTwo")]
    public partial class Routing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Routing</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5>Routing with multiple Urls</h5>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p><text style=\"color:goldenrod\">Should specify the URL at top of the page using</text> <strong><i>\"page\" directive</i></strong></p>\r\n\r\n");
            __builder.AddMarkupContent(3, "<p style=\"color:darkorange\">Change the URL from another page to <i>\"/routingone\" or \"/routingtwo\"</i>, routing page will be redirected</p>\r\n\r\n");
            __builder.AddMarkupContent(4, "<a href=\"/Routeparameter/Show\"><button class=\"btn btn-outline-success\">Click Here!!</button></a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
