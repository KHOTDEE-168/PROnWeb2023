#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Shared\LoadingScreen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f457f1ab27f309bb859cca20114f08f272263b11"
// <auto-generated/>
#pragma warning disable 1591
namespace PrOnWeb.Pages.Shared
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
    public partial class LoadingScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Shared\LoadingScreen.razor"
 if (isLoaded)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Shared\LoadingScreen.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Shared\LoadingScreen.razor"
                 
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div>Loading screen...</div>\r\n");
#nullable restore
#line 8 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Shared\LoadingScreen.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Shared\LoadingScreen.razor"
       
    bool isLoaded;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(4000); // TODO actual initialization job
        isLoaded = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591