#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c4fa3aca9008722d30947cf905845db714a8f6"
// <auto-generated/>
#pragma warning disable 1591
namespace PrOnWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class RoleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "multiple-selector");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "selectable-ul");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
         foreach (var item in NoSelected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                            () => Select(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                                                  item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "multiple-selector-buttons");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                                        SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, ">>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                                        DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                                                      removeAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "selectable-ul");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 14 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
         foreach (var item in Selected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                            () => Deselect(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 16 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
                                                    item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\RoleSelector.razor"
       
    private string removeAllText = "<<";
    [Parameter]
    public List<Master_Role> NoSelected { get; set; } = new List<Master_Role>();
    [Parameter]
    public List<Master_Role> Selected { get; set; } = new List<Master_Role>();

    private void Select(Master_Role item)
    {
        NoSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(Master_Role item)
    {
        Selected.Remove(item);
        NoSelected.Add(item);
    }

    private void SelectAll()
    {
        Selected.AddRange(NoSelected);
        NoSelected.Clear();
    }

    private void DeselectAll()
    {
        NoSelected.AddRange(Selected);
        Selected.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
