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
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Users.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Users.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Users.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Users.razor"
           [Authorize(Roles = "Administrators")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Users.razor"
       
    SfGrid<AppUser> Grid;
    SfGrid<UserTable> GridNewUsers;
    List<ApplicationUser> applicationUsers;
    List<AppUser> allAppUsers;
    List<UserTable> allUsers;
    string NewUserName;
    string NewEmail;
    string NewFullName;

    bool isActiveUser;

    public class AppUser
    {
        public string PrUserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public bool IsActive { get; set; }
    }

    List<WorkflowAutho> workFlowAuthos;
    public async Task LoadAllUser()
    {
        allAppUsers = new List<AppUser>();
        AppUser appUser;
        bool isAddThis;
        foreach (var item in applicationUsers)
        {
            isAddThis = item.EmailConfirmed; // แสดงเฉพาะ Active User
            if (isActiveUser == false) // แสดงทั้งหมด
            {
                isAddThis = true;
            }
            if (isAddThis == true)
            {
                workFlowAuthos = await prDataService.GetWorkflowAuthosAsync(Int16.Parse(item.PrUserId));
                if (workFlowAuthos.Count == 0)
                {
                    appUser = new AppUser()
                    {
                        PrUserId = item.PrUserId,
                        UserName = item.UserName,
                        Email = item.Email,
                        FullName = item.FullName,
                        Company = "",
                        Department = "",
                        Section = "",
                        IsActive = item.EmailConfirmed
                    };
                    allAppUsers.Add(appUser);
                }
                else
                {
                    foreach (var wf in workFlowAuthos)
                    {
                        appUser = new AppUser()
                        {
                            PrUserId = item.PrUserId,
                            UserName = item.UserName,
                            Email = item.Email,
                            FullName = item.FullName,
                            Company = wf.Org,
                            Department = wf.Dep,
                            Section = wf.Sec,
                            IsActive = item.EmailConfirmed
                        };
                        allAppUsers.Add(appUser);
                    }
                }
            }
            Grid.Refresh();

        }
    }

    // ==================================================
    protected override async Task OnInitializedAsync()
    {
        isActiveUser = true; // เฉพาะ Active User
        applicationUsers = _UserManager.Users.ToList();
        await LoadAllUser();
        allUsers = await prDataService.GetUserTablesAsync();
    }

    public async Task SelectedRowCellIndex()
    {
        var value = await this.Grid.GetSelectedRecords();
        navigationManager.NavigateTo($"UserProfile/{value.First().UserName}");
    }

    private void Navigate(AppUser appUsr)
    {
        navigationManager.NavigateTo($"UserProfile/{appUsr.UserName}");
    }

    //public async Task RegisNewUser()
    //{
    //    int thisPrUserId;
    //    int maxPrUserId = 0;
    //    foreach (ApplicationUser user in allUser)
    //    {
    //        if (user.PrUserId != "" && user.PrUserId != null)
    //        {
    //            thisPrUserId = Int32.Parse(user.PrUserId);
    //            if (thisPrUserId > maxPrUserId)
    //            {
    //                maxPrUserId = thisPrUserId;
    //            }
    //        }
    //    }

    //    WorkflowAutho workflowAutho;

    //    foreach (ApplicationUser user in allUser)
    //    {
    //        if (user.PrUserId == null || user.PrUserId == "")
    //        {
    //            // gen new PrUserID
    //            maxPrUserId += 1;
    //            user.PrUserId = maxPrUserId.ToString();
    //            await _UserManager.UpdateAsync(user);
    //            // create new WorkflowAuthos
    //            //workflowAutho = new WorkflowAutho
    //            //{
    //            //    User_Id = maxPrUserId
    //            //};
    //            //await prDataService.CreateWorkflowAuthoAsync(workflowAutho);
    //        }
    //    }
    //}

    public string defaultPassword = "Abc123$$$";

    public async Task UpdateNewUser()
    {
        var passwordHasher = new PasswordHasher<ApplicationUser>();
        // add new user
        ApplicationUser newUser;
        string hashedPwd;
        int newPrUserId;
        foreach (var item in allUsers)
        {
            newUser = await _UserManager.FindByNameAsync(item.UserName.Trim());
            if (newUser == null)
            {
                newPrUserId = await prDataService.GetNextPrUserId();
                newUser = new ApplicationUser();
                newUser.UserName = item.UserName.Trim();
                hashedPwd = passwordHasher.HashPassword(newUser, defaultPassword);
                newUser.PasswordHash = hashedPwd;
                newUser.Email = item.Email;
                newUser.PhoneNumber = "";
                newUser.PrUserId = newPrUserId.ToString();
                newUser.FullName = item.FullName;
                newUser.EmailConfirmed = true;
                var result0 = await _UserManager.CreateAsync(newUser);
            }
            else // Update
            {
                newUser.UserName = item.UserName.Trim();
                newUser.Email = item.Email;
                newUser.PhoneNumber = "";
                newUser.FullName = item.FullName;
                newUser.EmailConfirmed = true;
                var result1 = await _UserManager.UpdateAsync(newUser);
            }
        }
        Grid.Refresh();

    }

    public async Task AddOneUser()
    {
        var passwordHasher = new PasswordHasher<ApplicationUser>();
        // add new user
        ApplicationUser newUser;
        string hashedPwd;
        int newPrUserId;
        newUser = await _UserManager.FindByNameAsync(NewUserName.Trim());
        if (newUser == null)
        {
            newPrUserId = await prDataService.GetNextPrUserId();
            newUser = new ApplicationUser();
            newUser.UserName = NewUserName.Trim();
            hashedPwd = passwordHasher.HashPassword(newUser, defaultPassword);
            newUser.PasswordHash = hashedPwd;
            newUser.Email = NewEmail;
            newUser.PhoneNumber = "";
            newUser.PrUserId = newPrUserId.ToString();
            newUser.FullName = NewFullName;
            newUser.EmailConfirmed = true;
            var result0 = await _UserManager.CreateAsync(newUser);
        }
        else // Update
        {
            newUser.UserName = NewUserName.Trim();
            newUser.Email = NewEmail;
            newUser.PhoneNumber = "";
            newUser.FullName = NewFullName;
            newUser.EmailConfirmed = true;
            var result1 = await _UserManager.UpdateAsync(newUser);
        }
        NewUserName = "";
        NewEmail = "";
        NewFullName = "";
        Grid.Refresh();
    }

    public async Task DeleteImportUserTable()
    {
        await prDataService.DeleteUserTableAsync();
        allUsers = await prDataService.GetUserTablesAsync();
        GridNewUsers.Refresh();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
