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
#line 1 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/predit/{PrId:int}")]
    public partial class PrEdit : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 547 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\PrEdit.razor"
       

    private Boolean isLoading = true;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }

    string FullName = "", Username = "";
    ApplicationUser thisUser = new ApplicationUser();
    private AuthenticationState authState;
    ClaimsPrincipal MyClaims = new ClaimsPrincipal();

    private DialogSettings DialogParams = new DialogSettings { MinHeight = "500px", Width = "800px" };

    bool isActiveUser;
    List<Master_Org> allMasterOrgs;
    List<Master_Dep> allMasterDeps;
    List<Master_Sec> allMasterSecs;
    List<Master_Unit> unitDDL;
    List<Master_Currency> currencyDDL;

    SfTextBox TextBoxDateObj;
    public async Task OnCreateDate()
    {
        this.TextBoxDateObj.AddIcon("append", "e-date-icon");
    }


    [Parameter] public int PrId { get; set; }

    public DateTime DateValue { get; set; } = DateTime.Now;
    public DateTime DateNeed { get; set; } = DateTime.Now;

    string SelOrg = "";
    string SelDep = "";
    string SelSec = "";

    string isUrgent = "No";
    Boolean isNotUrgent = false;

    private Boolean Check = false;
    private Boolean isCostCenter = false;
    private Boolean isWSB = false;
    private Boolean isWSBReq = true;

    /* Grid */
    public SfGrid<PRItem> PRGrid;
    string PrStatus;
    string PrStatusName;
    PRHeader prHeader = new PRHeader();
    List<PRItem> prItems = new List<PRItem>();
    //PRItem prItem;
    string thisPrODS; // ODS=Company, Department, Section คั่นด้วย "-"
    bool isMySectionPr; // ODS ของ PR ใบนี้ตรงกับ ODS ของ WF_Autho ของเรา
    string thisPrOD;
    bool isMyDepartmentPr;
    string thisPrO;
    bool isMyCompanyPr;
    bool isStaffChooser;
    bool isFormValid = false;
    private bool PreventAdd { get; set; } = false;


    string PROrg = "CP01";
    //string HPRGroup;

    //[Required]
    //string HCompany,HProject,HLocation;

    //[Required]
    //string Department, Section, TrackingNo;

    string GL_Account, Cost_Center, WBS_Code, Item_Code, Item_Description, Material_Group, Material_Group_Des, Extension, BudgetRange;
    double Price_PR = 0, ExRate = 0, Quantity = 0, Amount = 0, AmountTHB = 0;

    float EstimateCost = 0;

    List<ParamConfig> locationDDL = new List<ParamConfig>();
    List<ParamConfig> projectDDL = new List<ParamConfig>();
    List<ParamConfig> masterProjetDDL = new List<ParamConfig>();
    List<MatGroupList> MatCodeItemDDL = new List<MatGroupList>();

    //private List<Object> Toolbaritems = new List<Object>() { "Add New Item" , new ItemModel() { Text = "Click", TooltipText = "Click", PrefixIcon = "e-click", Id = "Click" } };
    private List<Object> Toolbaritems = new List<Object>() { "Add", "Edit", "Delete" };


    //public string[] UnitEnumValues { get; set; } = Enum.GetNames(typeof(Unit));


    protected override async Task OnInitializedAsync()
    {
        //base.OnInitialized();
        authState = await _authState;
        MyClaims = (await _authState).User;
        thisUser = _UserManager.Users.FirstOrDefault(x => x.UserName == MyClaims.Identity.Name);
        if (thisUser != null)
        {
            FullName = thisUser.FullName;

            //prHeader.Requester = thisUser.UserName;

        }


        await Task.Delay(800);

        unitDDL = await prDataService.GetUnitAsync();
        currencyDDL = await prDataService.GetCurrencyAsync();

        allMasterOrgs = await prDataService.GetMasterOrgsAsync(thisUser.PrUserId);
        allMasterDeps = await prDataService.GetMasterDepsAsync(thisUser.PrUserId);
        allMasterSecs = await prDataService.GetMasterSecsAsync(thisUser.PrUserId);
        //MatCodeItemDDL = await prDataService.GetMatCodeItem(HCompany);


        //if (null != allMasterOrgs && allMasterOrgs.Count == 1)
        //{
        //    prHeader.Company = allMasterOrgs.First().Org;
        //}

        //if (null != allMasterDeps && allMasterDeps.Count == 1)
        //{
        //    prHeader.Department = allMasterDeps.First().Dep;
        //}

        //if (null != allMasterSecs && allMasterSecs.Count == 1)
        //{
        //    prHeader.Section = allMasterSecs.First().Sec;
        //}
        //allMasterOrgs = await prDataService.GetMasterOrgsAsync();
        //allMasterDeps = await prDataService.GetMasterDepsAsync();
        //allMasterSecs = await prDataService.GetMasterSecsAsync();
        MatCodeItemDDL = await prDataService.GetMatCodeItem(prHeader);

        //prHeader = new PRHeader();
        locationDDL.Add(new ParamConfig("HO", "HO"));
        locationDDL.Add(new ParamConfig("PLANT", "PLANT"));


        projectDDL.Add(new ParamConfig("MP01", "MEPT", "MEPT"));
        projectDDL.Add(new ParamConfig("PA01", "TPAC Project 1", "TPAC"));
        projectDDL.Add(new ParamConfig("PA02", "TPAC Project 2", "TPAC"));
        projectDDL.Add(new ParamConfig("PA03", "TPAC Project 3", "TPAC"));
        projectDDL.Add(new ParamConfig("PC01", "TPCC Project 1", "TPCC"));

        masterProjetDDL = projectDDL;



        //await this.PRGrid.EnableToolbarItems(new List<string>() { "Grid_PrForm_add" }, false);

        // Load Pr
        prHeader = await prMainService.GetPrHeaderAsync(PrId);
        if (prHeader.Pr_Urgent == null)
        {
            prHeader.Pr_Urgent = "No";
        }

        prItems = await prMainService.GetPrItemsAsync(PrId);


        //float ecost = 0 ;
        EstimateCost = 0;
        var itmno = 1;
        foreach (var pri in prItems)
        {
            pri.Item_No = itmno.ToString();
            pri.Amount = pri.Price_PR * pri.Quantity;

            pri.AmountTHB = pri.Amount * pri.ExRate;

            EstimateCost += pri.Amount;
            itmno++;
        }

        await FindBudgetRange();

        isLoading = false;

    }

    public async Task ActionBeginHandler(ActionEventArgs<PRItem> args)
    {

        Console.WriteLine("ActionBeginHandler: " + args.RequestType);

        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {
            // Triggers before add operation starts
            //args.RowData.PO_DATE = true;
            args.Index = prItems.Count();
            //args.Data.Id = prItems.Count()+1;
            args.Data.Item_No = (args.Index + 1).ToString();
            args.Data.Delivery_date = DateNeed.Date;
            args.Data.Currency = "THB";
            args.Data.ExRate = 1;
            args.Data.UOM = "PC";

            isCostCenter = true;
            isWSB = false;
            isWSBReq = true;

        }
        else
        {
            //Check = false;

            args.Index = prItems.Count();
            //args.Data.Id = prItems.Count()+1;
            //args.Data.Item_No = (args.Index + 1).ToString();
            //args.Data.Delivery_date = DateNeed;
            //args.Data.Currency = "THB";
            //args.Data.ExRate = 1;
            //args.Data.UOM = "PC";

            GetCostCenter();


            var matCode = args.Data.Item_Code;
            if (string.IsNullOrWhiteSpace(matCode))
            {
                isCostCenter = true;
                isWSB = false;
                isWSBReq = true;
                //matCode = "-";
            }
            else
            {
                isCostCenter = false;
                isWSB = true;
                isWSBReq = false;
            }


            /**Set Exrate */
        }


        if (args.RequestType != Syncfusion.Blazor.Grids.Action.Cancel)
        {
            MatCodeItemDDL = await prDataService.GetMatCodeItem(prHeader);


        }

        StateHasChanged();
    }

    public async Task GridOnActionComplete(ActionEventArgs<PRItem> args)
    {
        Console.WriteLine("GridOnActionComplete: " + args.RequestType);
        if (args.RequestType != Syncfusion.Blazor.Grids.Action.Cancel)
        {
            //float ecost = 0 ;
            EstimateCost = 0;
            foreach (var pri in prItems)
            {
                EstimateCost += pri.AmountTHB;
            }

            await FindBudgetRange();
        }
    }

    private async Task FindBudgetRange()
    {
        // find budget range
        // input : prAmount // find from BudgetRanges
        List<BudgetRange> budgetRanges = await prDataService.GetBudgetRangeAsync();
        foreach (BudgetRange budgetRange in budgetRanges)
        {

            if (budgetRange.Range_Oper == "LE")
            {
                if (EstimateCost <= budgetRange.Range_Amount)
                {
                    //thisBudgetRange = budgetRange.Range_No;
                    BudgetRange = budgetRange.Range_Name;
                    break;
                }
            }
            else
            {
                if (EstimateCost > budgetRange.Range_Amount)
                {
                    //thisBudgetRange = budgetRange.Range_No;
                    BudgetRange = budgetRange.Range_Name;
                    break;
                }
            }
        }
    }
    public async Task CancelEdit()
    {
        await PRGrid.CloseEdit();
        StateHasChanged();
    }
    public async Task SaveEdit()
    {
        await PRGrid.EndEdit();
        StateHasChanged();
    }


    private async Task OnMatDescSelect(SelectEventArgs<MatGroupList> args, PRItem context)
    {

        context.Item_Code = args.ItemData.Item_Code;

        if (!string.IsNullOrEmpty(args.ItemData.Item_Description))
        {
            context.Item_Description = args.ItemData.Item_Description;
        }

        SetMatGroup(context.Item_Code, context);
    }

    private async Task OnMatCodeSelect(SelectEventArgs<MatGroupList> args, PRItem context)
    {

        context.Item_Code = args.ItemData.Item_Code;

        if (!string.IsNullOrEmpty(args.ItemData.Item_Description))
        {
            context.Item_Description = args.ItemData.Item_Description;
        }

        SetMatGroup(context.Item_Code, context);
    }


    private async Task OnMatCodeChange(ChangeEventArgs<string, MatGroupList> args, PRItem context)
    {
        //var val = null== args ? "":args.ToString();
        SetMatGroup(context.Item_Code, context);
    }

    private async Task OnMatDescChange(ChangeEventArgs<string, MatGroupList> args, PRItem context)
    {
        SetMatGroup(context.Item_Code, context);
    }

    public async Task SetMatGroup(string val, PRItem context)
    {

        // Get Cost Center ***

        //context.Item_Code = "";
        //context.Item_Description = "";
        context.Material_Group = "";
        context.Material_Group_Des = "";
        context.GL_Account = "";
        context.Cost_Center = "";
        context.WBS_Code = "";
        context.Account_Ass_Cat = "";

        //OnMatChange(context);
        var matCode = context.Item_Code;
        if (string.IsNullOrWhiteSpace(val))
        {
            isCostCenter = true;
            isWSB = false;
            isWSBReq = true;
            matCode = "-";
        }
        else
        {
            isCostCenter = false;
            isWSB = true;
            isWSBReq = false;
        }

        var matgrp = prDataService.GetMatGroup(matCode);


        if (matgrp != null && matgrp.Material_Group != null)
        {
            context.Material_Group = matgrp.Material_Group;
            context.Material_Group_Des = matgrp.Material_Group_Des;
            context.GL_Account = matgrp.GL_Account;
            context.Account_Ass_Cat = matgrp.Account_Ass_Cat;
            if (context.Account_Ass_Cat != null && Int32.Parse(context.Account_Ass_Cat) > 0)
            {
                context.Cost_Center = CostCenter;
            }
        }

        //if (args.ItemData.GL_Account != null )
        //{
        //    context.GL_Account = args.ItemData.GL_Account;
        //}
        //if (args.ItemData.Account_Ass_Cat!= null)
        //{
        //    context.Account_Ass_Cat = args.ItemData.Account_Ass_Cat;
        //    if (context.Account_Ass_Cat.Length > 0 && Int32.Parse(context.Account_Ass_Cat) > 0)
        //    {
        //        context.Cost_Center = args.ItemData.Cost_Center;
        //    }
        //}

        this.StateHasChanged();
        //context.Account_Ass_Cat =

    }


    //(ChangeEventArgs<string, GameFields> args)

    public async Task CalAmount(Microsoft.AspNetCore.Components.ChangeEventArgs args, PRItem context)
    {
        await CalAmount(context);
    }

    public async Task CalAmount(PRItem context)
    {
        float rate = context.ExRate != null ? context.ExRate : 1;
        context.Amount = context.Quantity * context.Price_PR;
        context.AmountTHB = context.Amount * rate;
        this.StateHasChanged();
    }



    //SfAutoComplete<string, PRItem> autoObj { get; set; }
    private async Task OnCompanyChange()
    {
        // Filter Project
        projectDDL = masterProjetDDL.Where(a => a.type == prHeader.Company).ToList();

        // Set Material Store
        MatCodeItemDDL = await prDataService.GetMatCodeItem(prHeader);

        // Enabled Add Button


        this.StateHasChanged();

    }


    bool isCreatePRSuccess = false;
    string CostCenter = "";

    public async Task GetCostCenter()
    {
        if (!string.IsNullOrEmpty(prHeader.Plant) && !string.IsNullOrEmpty(prHeader.Department) && !string.IsNullOrEmpty(prHeader.Section))
        {
            CostCenter = prDataService.GetGetCostCenter(prHeader.Plant, prHeader.Department, prHeader.Section);

            this.PRGrid.EnableToolbarItems(new List<string>() { "Grid_PrForm_add" }, true);
        }
        else
        {
            this.PRGrid.EnableToolbarItems(new List<string>() { "Grid_PrForm_add" }, false);
        }

    }


    public async Task GetPRGroup()
    {
        if (string.IsNullOrEmpty(prHeader.Plant) || string.IsNullOrEmpty(prHeader.Location) && !string.IsNullOrEmpty(prHeader.Purchasing_Group))
        {
            prHeader.Purchasing_Group = "";
        }

        if (!string.IsNullOrEmpty(prHeader.Plant) && !string.IsNullOrEmpty(prHeader.Location))
        {
            prHeader.Purchasing_Group = prDataService.GetGetPRGroup(prHeader.Plant, prHeader.Location);
        }

        await GetCostCenter();

        this.StateHasChanged();
    }


    public async Task CurrencyValueChange(ChangeEventArgs<string, Master_Currency> args, PRItem context)
    {
        context.ExRate = args.ItemData.Rate;
        await CalAmount(context);
    }

    bool isSavePR = false, isHasPRItem = true;
    private async Task FormSubmit(EditContext context)
    {
        // Validates the EditContext and returns bool to indicate whether it has valid or invalid input values.
        isSavePR = context.Validate();
        if (isSavePR)
        {
            // Form has valid inputs.


            if (prItems != null && prItems.Count > 0)
            {

                isHasPRItem = true;
                isLoading = true;
                if (await JsRuntime.InvokeAsync<bool>("confirm", "Please confirm Update PR ? "))
                {
                    //var fileName = await prDataService.DeleteUploadAttachAsync(attachId);
                    //File.Delete(env.WebRootPath + UploadPath + fileName);
                    //await GetUploadFileList();


                    var result = prDataService.UpdatePRData(prHeader, prItems);

                    isCreatePRSuccess = true;

                    navigationManager.NavigateTo($"prform/{PrId}",true);


                }
                else
                {
                    isLoading = false;
                }

            }
            else
            {
                isHasPRItem = false;
            }
            this.StateHasChanged();
        }
        else
        {
            // Form has invalid inputs.
        }
    }


    public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        Console.WriteLine("args.Item.Id: " + args.Item.Id);
        if (args.Item.Id == "Grid_PrForm_add")
        {



            //You can customize your code here.
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrMainService prMainService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
