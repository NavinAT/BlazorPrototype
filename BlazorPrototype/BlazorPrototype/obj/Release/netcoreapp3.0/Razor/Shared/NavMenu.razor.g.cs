#pragma checksum "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ab60a01a139e4740f6a152b1bd35d842ac8c32"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPrototype.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Employee Details</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> News feed\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "WidgetMandS/true");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> M&S Web site\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "<br>\r\n    ");
            __builder.OpenElement(38, "details");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.AddMarkupContent(40, "<summary style=\"color: whitesmoke\"><span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Blazor Features</summary>\r\n        ");
            __builder.OpenElement(41, "ul");
            __builder.AddAttribute(42, "class", "nav flex-column");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-item px-3");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "nav-link");
            __builder.AddAttribute(49, "href", "component");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Component\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "nav-item px-3");
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "class", "nav-link");
            __builder.AddAttribute(59, "href", "lifecycle");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Life Cycle\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "li");
            __builder.AddAttribute(65, "class", "nav-item px-3");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
            __builder.AddAttribute(68, "class", "nav-link");
            __builder.AddAttribute(69, "href", "formvalidation");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Form Validation\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "li");
            __builder.AddAttribute(75, "class", "nav-item px-3");
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
            __builder.AddAttribute(78, "class", "nav-link");
            __builder.AddAttribute(79, "href", "dependencyinjection");
            __builder.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(81, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> DI\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "li");
            __builder.AddAttribute(85, "class", "nav-item px-3");
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
            __builder.AddAttribute(88, "class", "nav-link");
            __builder.AddAttribute(89, "href", "routing");
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(91, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Routing\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "li");
            __builder.AddAttribute(95, "class", "nav-item px-3");
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(97);
            __builder.AddAttribute(98, "class", "nav-link");
            __builder.AddAttribute(99, "href", "jsinterop");
            __builder.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(101, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> JS Interop\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.OpenElement(104, "li");
            __builder.AddAttribute(105, "class", "nav-item px-3");
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(107);
            __builder.AddAttribute(108, "class", "nav-link");
            __builder.AddAttribute(109, "href", "insurancelocal");
            __builder.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(111, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> StateManagement\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.OpenElement(114, "li");
            __builder.AddAttribute(115, "class", "nav-item px-3");
            __builder.AddMarkupContent(116, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(117);
            __builder.AddAttribute(118, "class", "nav-link");
            __builder.AddAttribute(119, "href", "errorhandling");
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(121, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Error Handling\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.OpenElement(124, "li");
            __builder.AddAttribute(125, "class", "nav-item px-3");
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(127);
            __builder.AddAttribute(128, "class", "nav-link");
            __builder.AddAttribute(129, "href", "listemployees");
            __builder.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(131, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Employee Management\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "<br>\r\n    ");
            __builder.OpenElement(136, "details");
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.AddMarkupContent(138, "<summary style=\"color: whitesmoke\"><span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Core Features</summary>\r\n        ");
            __builder.OpenElement(139, "ul");
            __builder.AddAttribute(140, "class", "nav flex-column");
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.OpenElement(142, "li");
            __builder.AddAttribute(143, "class", "nav-item px-3");
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(145);
            __builder.AddAttribute(146, "class", "nav-link");
            __builder.AddAttribute(147, "href", "insurance");
            __builder.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(149, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Dynamic Curd\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(150, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.OpenElement(152, "li");
            __builder.AddAttribute(153, "class", "nav-item px-3");
            __builder.AddMarkupContent(154, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(155);
            __builder.AddAttribute(156, "class", "nav-link");
            __builder.AddAttribute(157, "href", "eventcallback");
            __builder.AddAttribute(158, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(159, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Event Callback\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(160, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n            ");
            __builder.OpenElement(162, "li");
            __builder.AddAttribute(163, "class", "nav-item px-3");
            __builder.AddMarkupContent(164, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(165);
            __builder.AddAttribute(166, "class", "nav-link");
            __builder.AddAttribute(167, "href", "onewaybinding");
            __builder.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(169, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Data Binding\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(170, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n            ");
            __builder.OpenElement(172, "li");
            __builder.AddAttribute(173, "class", "nav-item px-3");
            __builder.AddMarkupContent(174, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(175);
            __builder.AddAttribute(176, "class", "nav-link");
            __builder.AddAttribute(177, "href", "CustomLayout");
            __builder.AddAttribute(178, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(179, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> CustomLayout\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(180, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n            ");
            __builder.OpenElement(182, "li");
            __builder.AddAttribute(183, "class", "nav-item px-3");
            __builder.AddMarkupContent(184, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(185);
            __builder.AddAttribute(186, "class", "nav-link");
            __builder.AddAttribute(187, "href", "tabletemplate");
            __builder.AddAttribute(188, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(189, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Generic Table\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(190, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n            ");
            __builder.OpenElement(192, "li");
            __builder.AddAttribute(193, "class", "nav-item px-3");
            __builder.AddMarkupContent(194, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(195);
            __builder.AddAttribute(196, "class", "nav-link");
            __builder.AddAttribute(197, "href", "Parentochildbinding");
            __builder.AddAttribute(198, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(199, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Generic Table\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(200, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(204);
            __builder.AddAttribute(205, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(206, "\r\n            ");
                __builder2.OpenElement(207, "ul");
                __builder2.AddAttribute(208, "class", "nav flex-column");
                __builder2.AddMarkupContent(209, "\r\n                ");
                __builder2.OpenElement(210, "li");
                __builder2.AddAttribute(211, "class", "nav-item px-3");
                __builder2.AddMarkupContent(212, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(213);
                __builder2.AddAttribute(214, "class", "nav-link");
                __builder2.AddAttribute(215, "href", "logout");
                __builder2.AddAttribute(216, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(217, "\r\n                        <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Logout\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(218, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(219, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(221, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "C:\NAVEEN\Education\Blazor Prototype\BlazorPrototype\BlazorPrototype\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
