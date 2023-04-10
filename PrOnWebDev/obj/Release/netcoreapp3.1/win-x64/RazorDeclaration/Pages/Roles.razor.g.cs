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
#nullable restore
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Roles.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Roles.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Roles.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Roles.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Roles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles")]
    public partial class Roles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Roles.razor"
       

    //public List<IdentityRole> allRole { get; set; }
    List<Master_Role> allRole;
    SfGrid<Master_Role> Grid;
    SfGrid<UserTable> UserGrid;
    string RoleName;
    Master_Role SelectedRole;
    List<UserTable> userTables;

    public bool ConfirmDlgVisible { get; set; } = false;
    public bool flag { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        //allRole = _RoleManager.Roles.ToList();
        allRole = await prDataService.GetMasterRolesAsync();
    }

    public void HideDialog(Object e)
    {
        this.ConfirmDlgVisible = false;
    }

    public bool IsVisible { get; set; } = false;

    protected void CreateRole()
    {
        IsVisible = true;
    }

    public async Task ActionBegin(ActionEventArgs<Master_Role> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {
            // Triggers before editing operation starts
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {
            // Triggers before add operation starts
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {
            // Triggers before cancel operation starts
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            // Triggers before save operation starts
            args.Cancel = true;
            if (args.Action == "Edit")
            {
                SelectedRole = args.Data;
                await UpdateRole();
            }
            else
            {
                SelectedRole = new Master_Role()
                {
                    Role = args.Data.Role
                };
                await ActionCreateRole();
            }
            allRole = await prDataService.GetMasterRolesAsync();
            Grid.Refresh();

        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
        {
            // Triggers before delete operation starts
            this.ConfirmDlgVisible = true;
            args.Cancel = true;            //cancel the delete action
            SelectedRole = args.Data;
        }

    }
    public async Task ActionClick(RowSelectingEventArgs<Master_Role> args)
    {
        int RoleId = args.Data.Id;
        userTables = await prDataService.GetUsersFromRoleAsync(RoleId);
        UserGrid.Refresh();
    }


    public async Task ActionComplete(ActionEventArgs<Master_Role> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {
            // Triggers once editing operation completes
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {
            //
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {
            // Triggers once cancel operation completes
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            // Triggers once save operation completes

        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
        {
            // Triggers once delete operation completes
        }
    }

    private List<ToastModel> Toast = new List<ToastModel>
{
        new ToastModel{ Title = "Success!", Content="Role created." },
        new ToastModel{ Title = "Success!", Content="Role Updated." },
        new ToastModel{ Title = "Success!", Content="Role Deleted." },
    };
    public string ToastContent = "Content of Toast";
    SfToast ToastObj;
    protected async Task ActionCreateRole()
    {
        IsVisible = false;
        string result = await prDataService.CreateMasterRolesAsync(SelectedRole);
        if (result == "OK")
        {
            await this.ToastObj.Show(Toast[0]);
        }
        else
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Cannot create this role.");
        }
    }

    protected async Task UpdateRole()
    {
        string result = await prDataService.UpdateMasterRolesAsync(SelectedRole);
        if (result == "OK")
        {
            await this.ToastObj.Show(Toast[1]);
        }
        else
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Cannot update this role.");
        }

    }

    public async Task YesDeleteDialog(Object e)
    {
        this.ConfirmDlgVisible = false;
        string result = await prDataService.DeleteMasterRolesAsync(SelectedRole);
        if (result == "OK")
        {
            await this.ToastObj.Show(Toast[2]);
            allRole = await prDataService.GetMasterRolesAsync();
            Grid.Refresh();
        }
        else
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Cannot delete this role.");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591