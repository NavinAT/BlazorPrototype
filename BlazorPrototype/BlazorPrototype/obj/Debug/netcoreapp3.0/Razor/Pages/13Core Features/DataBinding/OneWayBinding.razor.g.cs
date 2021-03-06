#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DataBinding\OneWayBinding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d0d3e0b9b7308eec8a8707dcc615556ab7ff4d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPrototype.Pages._13Core_Features.DataBinding
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/OneWayBinding")]
    public partial class OneWayBinding : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "div-container");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "details");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<summary style=\"color: darkslateblue; font-size: large; font-weight: bolder\">One Way Data Binding</summary>\r\n            ");
            __builder.AddMarkupContent(6, "<p><strong>&#8608; </strong>One way binding is directly binding the <i>\'Variable values\'</i> to the Html elements.</p>\r\n            ");
            __builder.AddMarkupContent(7, "<p><strong>&#8608; </strong>Using <b>\"&#64;\"</b> <i>\'Variable values\'</i> can be displayed with Html elements content.</p>\r\n            ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "style", "color:" + " " + (
#nullable restore
#line 8 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DataBinding\OneWayBinding.razor"
                              StyleClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<strong>&#8608; </strong>We can specify style values via ");
            __builder.AddMarkupContent(11, "<i>\'Variables\'</i> to the Html Elements");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "p");
            __builder.AddMarkupContent(14, "<strong>&#8608; </strong>");
            __builder.AddContent(15, 
#nullable restore
#line 9 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DataBinding\OneWayBinding.razor"
                                         HtmlContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<hr>\r\n");
            __builder.AddMarkupContent(19, "<a href=\"twowaybinding\"><strong>Navigate to Two way binding page.</strong></a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DataBinding\OneWayBinding.razor"
 
    private string StyleClass { get; set; } = "darkseagreen";
    private string HtmlContent { get; set; } = "Paragraph content can be assigned using Variables";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
