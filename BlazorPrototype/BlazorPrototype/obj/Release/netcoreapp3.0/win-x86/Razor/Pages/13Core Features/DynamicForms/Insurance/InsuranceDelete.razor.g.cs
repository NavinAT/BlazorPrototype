#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247c570e1bb228f1403010d193e4a9612762f674"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPrototype.Pages._13Core_Features.DynamicForms.Insurance
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
#line 3 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/insuranceDelete/{Id:int}")]
    public partial class InsuranceDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete Insurance</h3>\r\n<br>\r\n\r\n");
#nullable restore
#line 11 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
 if(rowEDINS != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorPrototype.Field>(2);
            __builder.AddAttribute(3, "ControlType", "TBText");
            __builder.AddAttribute(4, "LabelText", "Caption");
            __builder.AddAttribute(5, "Bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
                                                           rowEDINS["Caption"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Obj", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
                                                                                     rowEDINS

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<BlazorPrototype.Field>(8);
            __builder.AddAttribute(9, "ControlType", "TBText");
            __builder.AddAttribute(10, "LabelText", "ShortCaption");
            __builder.AddAttribute(11, "Bind", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
                                                                rowEDINS["ShortCaption"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Obj", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
                                                                                               rowEDINS

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 15 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n<br>\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
                  Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Delete");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\13Core Features\DynamicForms\Insurance\InsuranceDelete.razor"
       
    [Parameter]
    public int Id { get; set; }

    private DataRow rowEDINS;

    protected override void OnInitialized()
    {
        rowEDINS = InsuranceTable.FindById(Id);
    }

    private void Delete()
    {
        InsuranceTable.Remove(Id);
        rowEDINS = null;

        NavigationManager.NavigateTo("/insurance");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InsuranceTable InsuranceTable { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
