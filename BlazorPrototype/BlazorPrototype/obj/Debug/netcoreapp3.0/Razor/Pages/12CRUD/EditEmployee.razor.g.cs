#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a27ef61fcdfbe87649a4821502085814ffe1d1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPrototype.Pages._12CRUD
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
#nullable restore
#line 2 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
using BlazorPrototype.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{EmployeeNumber:guid}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
 if(IsAllowToDisplay)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.AddMarkupContent(1, "<h4>Edit Employee</h4>\r\n        <hr>\r\n");
#nullable restore
#line 10 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
     if(employee == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> No Employee record found to edit.\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
    }

    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "form");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-8");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.AddMarkupContent(16, "<label for=\"Name\">Name</label>\r\n                        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "id", "Name");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "Enter your Name");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                                                    employee.EmployeeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.EmployeeName = __value, employee.EmployeeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<label for=\"Department\">Department</label>\r\n                        ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "id", "Department");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "placeholder", "Enter your Department");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                                                                employee.Department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Department = __value, employee.Department));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.AddMarkupContent(40, "<label for=\"Salary\">Salary</label>\r\n                        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "id", "Salary");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "placeholder", "Enter your salary");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                                                        employee.Salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Salary = __value, employee.Salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "form-group");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.AddMarkupContent(52, "<label for=\"DOB\">Date Of Birth</label>\r\n                        ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "id", "DOB");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "placeholder", "Enter your Dob");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                                                  employee.Dob

#line default
#line hidden
#nullable disable
            , format: "dd/MM/yyyy"));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Dob = __value, employee.Dob, format: "dd/MM/yyyy"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.AddMarkupContent(64, "<label for=\"City\">City</label>\r\n                        ");
            __builder.OpenElement(65, "select");
            __builder.AddAttribute(66, "id", "City");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                       employee.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.City = __value, employee.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", true);
            __builder.AddContent(73, "--Select City--");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 42 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                             foreach(string strOption in DropDownValues)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                                ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", 
#nullable restore
#line 44 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                strOption

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, 
#nullable restore
#line 44 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                            strOption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 45 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "row");
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col-md-8");
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "form-group");
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "button");
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                                 () => OnUpdate.InvokeAsync(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "button");
            __builder.AddAttribute(102, "class", "btn");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 60 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\12CRUD\EditEmployee.razor"
      

    [Parameter] public EventCallback<EmployeeInformation> OnUpdate { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
