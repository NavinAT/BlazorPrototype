#pragma checksum "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\NewsFeed\WidgetMandS.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1011dbc6cce715bb59b2ef70b43001afd6a9b9aa"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Pages.NewsFeed
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using BlazorAppCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\_Imports.razor"
using EmployeeManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/WidgetMandS/{FullPage:bool}")]
    public partial class WidgetMandS : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "iframe");
            __builder.AddAttribute(1, "src", "https://www.m-s.ch/");
            __builder.AddAttribute(2, "width", 
#nullable restore
#line 2 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\NewsFeed\WidgetMandS.razor"
                                         width

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "height", 
#nullable restore
#line 2 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\NewsFeed\WidgetMandS.razor"
                                                       height

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "style", "border: none");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\NewsFeed\WidgetMandS.razor"
       

    [Parameter]
    public bool FullPage { get; set; }

    private string width { get { return (FullPage) ? "1600px" : "798px"; } }
    private string height { get { return (FullPage) ? "800px" : "390px"; } }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
