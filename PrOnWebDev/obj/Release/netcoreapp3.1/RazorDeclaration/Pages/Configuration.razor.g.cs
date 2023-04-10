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
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/configuration")]
    public partial class Configuration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Configuration.razor"
       
    public string CSVImportPath = "/CoStorage/";
    public string CSVArchivePath = "/RawDataArchive/";
    public string sPdHo;
    public string sPdRy;
    public string sCO; // Co Sign
    public string sAC; // Accounting

    public int? FuSize;
    public string FuPath;
    public List<SystemConfiguration> configs;
    public int PasswordExpirationDays;

    //Budget Range setting
    List<BudgetRange> budgetRanges = new List<BudgetRange>();
    SfGrid<BudgetRange> GridBR;

    protected override async Task OnInitializedAsync()
    {
        await loadConfiguration();
        budgetRanges = await prDataService.GetBudgetRangeAsync();
        PasswordExpirationDays = Int16.Parse(appConfig["PasswordExpirationDays"]);
    }

    protected async Task loadConfiguration()
    {
        configs = await prDataService.GetSystemConfigurationsAsync();
        CSVImportPath = configs.Where(x => x.ConfigName == "CSVImportPath").First().ConfigValue;
        CSVArchivePath = configs.Where(x => x.ConfigName == "CSVArchivePath").First().ConfigValue;
        sPdHo = configs.Where(y => y.ConfigName == "PDHO").First().ConfigValue;
        sPdRy = configs.Where(y => y.ConfigName == "PDRY").First().ConfigValue;
        //PdHo = configs.Where(y => y.ConfigName == "PDHO")
        //    .Select(x => x.ConfigValue)
        //    .ToList();
        //sPdHo = string.Join(",", PdHo.ToArray());
        //PdRy = configs.Where(y => y.ConfigName == "PDRY")
        //    .Select(x => x.ConfigValue)
        //    .ToList();
        //sPdRy = string.Join(",", PdRy.ToArray());
        sCO = configs.Where(y => y.ConfigName == "CO").First().ConfigValue;
        sAC = configs.Where(y => y.ConfigName == "AC").First().ConfigValue;
        FuPath = configs.Where(y => y.ConfigName == "FUPATH")
        .Select(x => x.ConfigValue)
        .FirstOrDefault();
        var xSize = configs.Where(y => y.ConfigName == "FUSIZE")
            .Select(x => x.ConfigValue)
            .FirstOrDefault();
        if (xSize == null)
        {
            FuSize = 0;
        }
        else
            FuSize = Int32.Parse(xSize);

        await PushConfig(); // เฉพาะ CSVImportPath, CSVArchivePath
    }

    private async Task SaveConfig()
    {
        // AppSetting
        //appConfig["PasswordExpirationDays"] = PasswordExpirationDays.ToString();
        // save Purchasing staff
        await prDataService.UpdateSystemConfigurationsAsync("PDHO", sPdHo);
        await prDataService.UpdateSystemConfigurationsAsync("PDRY", sPdRy);
        await prDataService.UpdateSystemConfigurationsAsync("CO", sCO);
        await prDataService.UpdateSystemConfigurationsAsync("AC", sAC);
        await prDataService.UpdateSystemConfigurationsAsync("FUPATH", FuPath);
        await prDataService.UpdateSystemConfigurationsAsync("FUSIZE", FuSize.ToString());
        // save upload
        await PushConfig();
        // save budget range
        foreach (var item in budgetRanges)
        {
            var BrLine = new BudgetRange()
            {
                Id = item.Id,
                Range_No = item.Range_No,
                Range_Oper = item.Range_Oper,
                Range_Amount = item.Range_Amount,
                Range_Name = item.Range_Name
            };
            await prDataService.UpdateBudgetRangeAsync(BrLine);
        }
        await jsRuntime.InvokeVoidAsync("alert", "Save Completed.");
    }

    private async Task PushConfig()
    {
        bool isUpdate = false;
        // เทียบใน mem กับ configs
        if (CSVImportPath != configs.Where(x => x.ConfigName == "CSVImportPath").First().ToString())
        {
            isUpdate = true;
        }
        if (CSVArchivePath != configs.Where(x => x.ConfigName == "CSVArchivePath").First().ToString())
        {
            isUpdate = true;
        }
        if (isUpdate)
        {
            prwaConfig.SetConfiguration(CSVImportPath, CSVArchivePath);
            foreach (var item in configs)
            {
                if (item.ConfigName == "CSVImportPath")
                {
                    item.ConfigValue = CSVImportPath;
                    await prDataService.UpdateSystemConfigurationsAsync(item);
                }
                if (item.ConfigName == "CSVArchivePath")
                {
                    item.ConfigValue = CSVArchivePath;
                    await prDataService.UpdateSystemConfigurationsAsync(item);
                }
            }
        }
    }

    bool isBudgetRangeDlgVisible = false;
    string BrNumber;
    string BrCondition;
    float? BrAmount;
    string BrName;
    int BrId;


    public void Navigate(BudgetRange bgr)
    {
        BrId = bgr.Id;
        BrName = bgr.Range_Name;
        BrNumber = bgr.Range_No.ToString();
        BrCondition = bgr.Range_Oper;
        BrAmount = bgr.Range_Amount;
        isBudgetRangeDlgVisible = true;
    }
    public void OnBrCancel()
    {
        isBudgetRangeDlgVisible = false;
    }
    public void OnBrSave()
    {
        var obj = budgetRanges.FirstOrDefault(x => x.Id == BrId);
        if (obj != null)
        {
            obj.Range_Name = BrName;
            obj.Range_Oper = BrCondition;
            obj.Range_Amount = BrAmount ?? 0;
        }
        isBudgetRangeDlgVisible = false;
        GridBR.Refresh();
    }

    private void Import()
    {
        import.ImportPR();
    }

    private async Task SetPasswordDate()
    {
        if (await jsRuntime.InvokeAsync<bool>("confirm", "Please confirm Reset ALL Password Change Date"))
        {
            List<ApplicationUser> applicationUsers;
            applicationUsers = _UserManager.Users.ToList();
            ApplicationUser user;
            // add new user
            foreach (var item in applicationUsers)
            {
                item.LastPasswordChangedDate = DateTime.Now;
                var result1 = await _UserManager.UpdateAsync(item);
            }
            await jsRuntime.InvokeVoidAsync("alert", "Done.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration appConfig { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.ImportCSV import { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Data.PrwaConfiguration prwaConfig { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591
