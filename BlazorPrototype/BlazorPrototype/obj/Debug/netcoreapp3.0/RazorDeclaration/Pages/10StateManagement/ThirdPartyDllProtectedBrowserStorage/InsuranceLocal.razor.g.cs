#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\10StateManagement\ThirdPartyDllProtectedBrowserStorage\InsuranceLocal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5834197b3d0d828fcd53b29c1f14c3dffc5208"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPrototype.Pages._10StateManagement.ThirdPartyDllProtectedBrowserStorage
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
#line 2 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\10StateManagement\ThirdPartyDllProtectedBrowserStorage\InsuranceLocal.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/insurancelocal")]
    public partial class InsuranceLocal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Pages\10StateManagement\ThirdPartyDllProtectedBrowserStorage\InsuranceLocal.razor"
       
    Insurance _insurance;

    protected override async Task OnAfterRenderAsync(bool bfirstRender)
    {
        if(bfirstRender)
        {
            await LoadStateAsync();
            StateHasChanged();
        }
    }

    async Task LoadStateAsync()
    {
        _insurance = await ProtectedLocalStorage.GetAsync<Insurance>("insurance");
    }

    async Task SetInsuranceDetails()
    {
        _insurance = new Insurance
        {
            InsuranceName = "LIC",
            Caption = "Life Insurance Corporation",
            InsuranceCode = 100013
        };

        await ProtectedLocalStorage.SetAsync("insurance", _insurance);
    }

    class Insurance
    {
        public string InsuranceName { get; set; }
        public string Caption { get; set; }
        public int InsuranceCode { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage ProtectedLocalStorage { get; set; }
    }
}
#pragma warning restore 1591
