#pragma checksum "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\ListEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cc0ca0d586b79606f1ccb75a32362cf78f7906"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EmployeeManagement.Pages.CRUD
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
#nullable restore
#line 4 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\ListEmployees.razor"
using EmployeeManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\ListEmployees.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listemployees")]
    public partial class ListEmployees : ListEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\ListEmployees.razor"
 
    private bool bShowEditEmployee { get; set; }
    private Guid EmployeeId { get; set; }

    private void ShowEditRazor(Guid uqEmployeeId)
    {
        EmployeeId = uqEmployeeId;
        bShowEditEmployee = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
