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
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Notification.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Notification.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Notification")]
    public partial class Notification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Notification.razor"
       
    // Who Am I
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal CurrentUser = new ClaimsPrincipal();

    int myUserId;

    Boolean isAccounting;
    Boolean isCoSign;
    List<Approval_flow> approval_Flows = new List<Approval_flow>();
    List<vPRHeader> pRHeaders = new List<vPRHeader>();

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        CurrentUser = (await _authState).User;

        if (CurrentUser.Identity.IsAuthenticated)
        {

            myUserId = Int16.Parse(CurrentUser.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);
            List<WorkflowAutho> workflowAuthos;
            List<vPRHeader> qPrHeaders = new List<vPRHeader>();
            workflowAuthos = await prDataService.GetWorkflowAuthoAsync(myUserId);
            List<Approval_flow> approval_Flows;
            //
            foreach (WorkflowAutho workflowAutho in workflowAuthos)
            {
                if (workflowAutho.IsAccount)
                {
                    isAccounting = true;

                    approval_Flows = await prDataService.GetApprovalFlowForRoleAsync("A");
                    foreach (Approval_flow approval_Flow in approval_Flows)
                    {
                        qPrHeaders.Add(await prDataService.GetvPrHeaderAsync(approval_Flow.Pr_id));
                    }
                }
                if (workflowAutho.IsCoSign)
                {
                    // มี Pending Approve ที่เป็นของเราหรือไม่
                    isCoSign = true;
                    approval_Flows = await prDataService.GetApprovalFlowForRoleAsync("C");
                    foreach (Approval_flow approval_Flow in approval_Flows)
                    {
                        qPrHeaders.Add(await prDataService.GetvPrHeaderAsync(approval_Flow.Pr_id));
                    }
                }

                if (workflowAutho.IsPM)
                {
                    qPrHeaders = await prDataService.GetPrHeaderForStatusAsync("PURS");
                }
                if (qPrHeaders != null)
                {
                    pRHeaders.AddRange(qPrHeaders);
                }

                if (workflowAutho.IsRequester)
                {
                    // มี PR ODS ของเราที่เป็น NEW ที่รอยู่หรือไม่
                    qPrHeaders = await prDataService.GetPrHeaderNotCloseAsync(workflowAutho.Org, workflowAutho.Dep, workflowAutho.Sec);
                }
                if (qPrHeaders != null)
                    pRHeaders.AddRange(qPrHeaders);
            }
        }
    }
    private void Navigate(int Pr_Id)
    {
        navigationManager.NavigateTo($"/prform/{Pr_Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591
