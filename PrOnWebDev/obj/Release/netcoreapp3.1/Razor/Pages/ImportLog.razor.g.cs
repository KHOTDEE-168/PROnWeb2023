#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9dc0599aa0097c94c56ba592da711d3e496e6f"
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
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/importLog")]
    public partial class ImportLog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Import Log</h3>\r\n");
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
 if (importLogs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.PrOnWeb.Pages.ImportLog.TypeInference.CreateSfGrid_0(__builder, 3, 4, 
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                     importLogs

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                                              true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSortSettings>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridSortColumns>(12);
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(14, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridSortColumn>(15);
                        __builder4.AddAttribute(16, "Field", "Id");
                        __builder4.AddAttribute(17, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SortDirection>(
#nullable restore
#line 15 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                                                  SortDirection.Descending

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(21);
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(24);
                    __builder3.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "HeaderText", "Id");
                    __builder3.AddAttribute(27, "Width", "50");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(29);
                    __builder3.AddAttribute(30, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Import_DateTime)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "HeaderText", "Date Time");
                    __builder3.AddAttribute(32, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(34);
                    __builder3.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Raw_Record_Count)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "HeaderText", "#Raw");
                    __builder3.AddAttribute(37, "Width", "40");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(39);
                    __builder3.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Import_File_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "HeaderText", "File Name");
                    __builder3.AddAttribute(42, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(44);
                    __builder3.AddAttribute(45, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Good_Record_Count)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "HeaderText", "#Good");
                    __builder3.AddAttribute(47, "Width", "40");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(49);
                    __builder3.AddAttribute(50, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Bad_Record_Count)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "HeaderText", "#Bad");
                    __builder3.AddAttribute(52, "Width", "40");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(54);
                    __builder3.AddAttribute(55, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Pr_Header_Id_Start)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "HeaderText", "Header Id");
                    __builder3.AddAttribute(57, "Width", "50");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(59);
                    __builder3.AddAttribute(60, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Pr_Header_Count)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "HeaderText", "#of Headers");
                    __builder3.AddAttribute(62, "Width", "40");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(64);
                    __builder3.AddAttribute(65, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Pr_Item_Id_Start)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "HeaderText", "Item Id");
                    __builder3.AddAttribute(67, "Width", "50");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(69);
                    __builder3.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
                           nameof(Import_Log.Pr_Item_Count)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "HeaderText", "#Items");
                    __builder3.AddAttribute(72, "Width", "40");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n");
            }
            );
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 31 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\ImportLog.razor"
       
    List<Import_Log> importLogs;
    protected override async Task OnInitializedAsync()
    {
        importLogs = await prDataService.GetImportLogsAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
namespace __Blazor.PrOnWeb.Pages.ImportLog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowResizing", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
