#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b2c1614cc96d0dcaeac08b11470dcf22a7b9d4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPrototype.Pages._13Core_Features.TemplatedComponents.TemplatedTable
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
    public partial class DataGrid<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-hover");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor"
             DataGridHeader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 8 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor"
     foreach(TItem item in Items)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "tr");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor"
             DataGridColumn(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 11 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "tfoot");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "tr");
            __builder.AddContent(20, 
#nullable restore
#line 14 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor"
             DataGridFooter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\TemplatedComponents\TemplatedTable\DataGrid.razor"
       

    [Parameter]
    public RenderFragment DataGridHeader { get; set; }

    [Parameter]
    public RenderFragment<TItem> DataGridColumn { get; set; }

    [Parameter]
    public RenderFragment DataGridFooter { get; set; }

    [Parameter]
    public IReadOnlyList<TItem> Items { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
