#pragma checksum "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c4fa3aca9008722d30947cf905845db714a8f6"
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
#line 1 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
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
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "selectable-ul");
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
         foreach (var item in NoSelected)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                            () => Select(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                                                  item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "multiple-selector-buttons");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                                        SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, ">>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                                        DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                                                      removeAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "selectable-ul");
#nullable restore
#line 14 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
         foreach (var item in Selected)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                            () => Deselect(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 16 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
                                                    item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RoleSelector.razor"
       
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
