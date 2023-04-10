// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Memo.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Memo.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Memo.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Memo.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/memo")]
    public partial class Memo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Memo.razor"
 
    [Parameter] public int prNo { get; set; }
    //[Parameter] public int userId { get; set; }

    SfTextBox SfTextBox;
    ObservableCollection<vPrMemo> DataSource = new ObservableCollection<vPrMemo>();

    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal MyClaims = new ClaimsPrincipal();

    int myUserId;

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        MyClaims = (await _authState).User;
        if (MyClaims.Identity.IsAuthenticated)
        {
            myUserId = Int16.Parse(MyClaims.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);
        }

        List<vPrMemo> prMemoRead = await prDataService.GetvPrMemoAsync(prNo);
        foreach (vPrMemo memo in prMemoRead)
        {
            DataSource.Add(memo);
        }
    }

    public string generateID()
    {
        return Guid.NewGuid().ToString("N");
    }

    protected async Task OnSend()
    {
        if (SfTextBox.Value != "")
        {
            vPrMemo prMemo = new vPrMemo
            {
                MemoWhoID = myUserId,
                MemoMsg = SfTextBox.Value,
                MemoWhen = DateTime.Now,
                PrID = prNo,
                Id = generateID()
                //Id = new Random().Next(300, 900).ToString()
            };
            DataSource.Add(prMemo);

            await prDataService.InsertvPrMemoAsync(prMemo);
        }
        SfTextBox.Value = "";

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591