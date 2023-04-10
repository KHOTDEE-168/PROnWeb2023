// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PrOnWeb.Pages.Utilities
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
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Utilities\MailSenderPage.razor"
           [Authorize(Roles = "Administrators")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MailUtil")]
    public partial class MailSenderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\Utilities\MailSenderPage.razor"
       
    string fromEmail = "TPP-PrOnWebDev@th.tpcc-tpac.com";
    string toEmail = "Saravut.tant@th.tpcc-tpac.com";
    //string fromEmail = "no-reply@beko.com";
    //string toEmail = "kroekpong@gmail.com";
    string PrNo = "0001-0002-0003";
    string PrHeaderId = "23031";
    string PrStatus = "Pending Approval";
    string ApprovalStatus = "No";
    string Role = "Approval";
    string Type = "Approver";

    private async void Sender()
    {
        //PrNoti nextPrNoti = new PrNoti()
        //{
        //    PrSAPNo = PrNo,
        //    PrId = Int32.Parse(PrHeaderId),
        //    PrStatus = PrStatus,
        //    ApproveStatus = ApprovalStatus,
        //    AsRole = Role
        //};

        vPRHeader prh = await prMainService.GetvPrHeaderAsync(Int32.Parse(PrHeaderId));

        EmailMessage emailMessage = new EmailMessage()
        {
            PrId = prh.Id.ToString(),
            PrNo = prh.Pr_No,
            //RequesterInfo = prh.Requester + ", COMPANY: " + prh.Company + ",DEPARTMENT: " + prh.Department + ", SECTION:" + prh.Section,
            RequesterInfo = prh.Requester,
            WBS = "",
            TotalCost = prh.sPrAmt,
            RequirementDate = (prh.Release_Date ?? DateTime.Now).ToString("dd/MM/yyyy"),
            StatusName = prh.PrStatus,
            Objective = prh.Objective,

            Company = prh.Company,
            Department = prh.Department,
            Section = prh.Section,
            Memo = "",
            Comment = prh.Comment,
            RN_TYPE = ""
        };

        MailKitService.SendNoti(fromEmail, toEmail, "Workflow assigned for PR No." + prh.Pr_No, emailMessage, Type);
        //MailKitService.SendNotiTest(fromEmail, toEmail, "Workflow assigned for PR No." + prh.Pr_No, emailMessage, Type);
        //await EmailService.SendEmailAsync(toEmail, "Waiting for your approval.", nextPrNoti);
    }

    string sSubject = "ACtion Required";
    string sBody = "Test Sending Email from Web App";

    private void PlainSender()
    {
        //await EmailService.SendPlainEmailAsync(toEmail, sSubject, sBody);
        MailKitService.Send("TPP-PrOnWebDev@th.tpcc-tpac.com", toEmail, sSubject, sBody);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrMainService prMainService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmailServices.IMailKitEmailService MailKitService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmailServices.IEmailService EmailService { get; set; }
    }
}
#pragma warning restore 1591
