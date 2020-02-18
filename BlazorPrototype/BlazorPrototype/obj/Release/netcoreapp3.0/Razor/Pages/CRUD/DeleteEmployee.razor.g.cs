#pragma checksum "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2983640b5561b52912ff6062c9f55a138c84e80"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteemployee/{EmployeeNumber:guid}")]
    public partial class DeleteEmployee : DeleteEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Delete Employee</h4>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-warning");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<strong>Warning!</strong> Do you really want to delete ");
            __builder.OpenElement(5, "b");
            __builder.AddContent(6, 
#nullable restore
#line 7 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                                                               employee.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, " record.\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 10 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
 if (employee == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<div class=\"alert alert-warning\">\r\n        <strong>Warning!</strong> No Employee record found to delete.\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<th>Employee Name</th>\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 23 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                 employee.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, "<th>Department</th>\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 27 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                 employee.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<th>Salary</th>\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 31 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                 employee.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<th>Date of Birth</th>\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 35 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                 employee.DOB

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<th>City</th>\r\n            ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 39 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                 employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-8");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                                                                        Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "btn");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 51 "C:\NAVEEN\Education\Blazor Projects\EmployeeManagement\EmployeeManagement\Pages\CRUD\DeleteEmployee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591