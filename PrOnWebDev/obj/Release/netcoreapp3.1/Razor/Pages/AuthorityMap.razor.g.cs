#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e83be55f1b10c2bc4eb8362cc67e4c29762988"
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
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/map")]
    public partial class AuthorityMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AuthorityMap</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "control-section");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control_wrapper col-lg-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfTreeView<TreeItem>>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __Blazor.PrOnWeb.Pages.AuthorityMap.TypeInference.CreateTreeViewFieldsSettings_0(__builder2, 10, 11, 
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
                                                 TreeDataSource

#line default
#line hidden
#nullable disable
                , 12, "NodeId", 13, "NodeText", 14, "Expanded", 15, 
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
                                                                 "Child"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.TreeViewEvents<TreeItem>>(17);
                __builder2.AddAttribute(18, "NodeSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.NodeSelectEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.NodeSelectEventArgs>(this, 
#nullable restore
#line 13 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
                                                            OnSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(19, "NodeClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.NodeClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.NodeClickEventArgs>(this, 
#nullable restore
#line 13 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
                                                                                   nodeClicked

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.AddMarkupContent(24, "<style>\r\n    #local-data, #remote-data {\r\n        max-width: 350px;\r\n        margin: 25px 60px;\r\n        padding-top: 15px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\WORK\2019\PH\PR Online\Source Code\Development\PrOnWebDev\Pages\AuthorityMap.razor"
       
    public class MasterData
    {
        public string ID { get; set; }
        public string Text { get; set; }
    }


    public List<string> selectedNodes = new List<string>();
    string selectedId;
    public void OnSelect(NodeSelectEventArgs args)
    {
        this.selectedId = args.NodeData.Id;
    }
    public void nodeClicked(NodeClickEventArgs args)
    {
        selectedNodes.Clear();
        selectedId = args.NodeData.Id;
        if (selectedId.StartsWith("S-"))
        {
            selectedNodes.Add(selectedId);

        }
    }



    //====
    List<TreeItem> TreeDataSource = new List<TreeItem>();
    protected override void OnInitialized()
    {
        base.OnInitialized();
        TreeDataSource.Add(new TreeItem
        {
            NodeId = "TPAC",
            NodeText = "THAI POLYACETAL",
            Expanded = false,
            Child = new List<TreeItem>()
        {
                new TreeItem { NodeId = "D-AC", NodeText = "AC",
                    Child = new List<TreeItem>()
                {
                        new TreeItem { NodeId = "S-AC", NodeText = "AC" }
                    },
                },
                new TreeItem { NodeId = "D-FI", NodeText = "FI",
                    Child = new List<TreeItem>()
                {
                        new TreeItem { NodeId = "S-FI", NodeText = "FI" }
                    },
                },
                new TreeItem { NodeId = "D-AD", NodeText = "AD",
                    Child = new List<TreeItem>()
                {
                        new TreeItem { NodeId = "S-AD", NodeText = "AD" },
                        new TreeItem { NodeId = "S-GA", NodeText = "GA" },
                        new TreeItem { NodeId = "S-HR", NodeText = "HR" }
                    },
                },
                new TreeItem { NodeId = "D-LG", NodeText = "LG",
                    Child = new List<TreeItem>()
                {
                        new TreeItem { NodeId = "S-EXP ", NodeText = "EXP "},
                        new TreeItem { NodeId = "S-WH", NodeText = "WH"},
                        new TreeItem { NodeId = "S-PLNG", NodeText = "PLNG"}
                    },
                },
                new TreeItem { NodeId = "D-PD", NodeText = "PD",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-K2T ", NodeText = "K2T "},
    new TreeItem { NodeId = "S-K2U", NodeText = "K2U"},
    new TreeItem { NodeId = "S-K2W", NodeText = "K2W"}
},},
new TreeItem { NodeId = "D-PH", NodeText = "PH",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-PH", NodeText = "PH"}
},},
new TreeItem { NodeId = "D-PS", NodeText = "PS",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-PS", NodeText = "PS"}
},},
new TreeItem { NodeId = "D-QC", NodeText = "QC",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-QC", NodeText = "QC"},
    new TreeItem { NodeId = "S-RD", NodeText = "RD"}
},},
new TreeItem { NodeId = "D-SHE", NodeText = "SHE",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-SHE", NodeText = "SHE"}
},},
new TreeItem { NodeId = "D-BC", NodeText = "BC",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-BC", NodeText = "BC"}
},},
new TreeItem { NodeId = "D-IT", NodeText = "IT",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-BAV", NodeText = "BAV"},
    new TreeItem { NodeId = "S-INF", NodeText = "INF"}
},},
new TreeItem { NodeId = "D-IC", NodeText = "IC",
Child = new List<TreeItem>() {
    new TreeItem { NodeId = "S-IC", NodeText = "IC"}
},},
                new TreeItem { NodeId = "D-ISO", NodeText = "ISO",
                    Child = new List<TreeItem>()
                {
                        new TreeItem { NodeId = "S-ISO", NodeText = "ISO" }
                    }
                },
                },
        });

        TreeDataSource.Add(new TreeItem
        {
            NodeId = "TPCC",
            NodeText = "THAI POLYCARBONATE",
            Child = new List<TreeItem>()
{
                new TreeItem { NodeId = "D-AC ", NodeText = "AC ",Child = new List<TreeItem>() {    new TreeItem { NodeId = "S-AC", NodeText = "AC"}    },},
new TreeItem { NodeId = "D-FI", NodeText = "FI",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-FI", NodeText = "FI"}    },},
new TreeItem { NodeId = "D-AD", NodeText = "AD",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-AD", NodeText = "AD"}    ,
    new TreeItem { NodeId = "S-GA", NodeText = "GA"}    ,
    new TreeItem { NodeId = "S-HR", NodeText = "HR"}    },},
new TreeItem { NodeId = "D-LG", NodeText = "LG",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-EXP ", NodeText = "EXP "}    ,
    new TreeItem { NodeId = "S-WH", NodeText = "WH"}    ,
    new TreeItem { NodeId = "S-PLNG", NodeText = "PLNG"}    },},
new TreeItem { NodeId = "D-PD", NodeText = "PD",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-PT", NodeText = "PT"}    ,
    new TreeItem { NodeId = "S-VP", NodeText = "VP"}    ,
    new TreeItem { NodeId = "S-COMPOUND", NodeText = "COMPOUND"}    },},
new TreeItem { NodeId = "D-PH", NodeText = "PH",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-PH", NodeText = "PH"}    },},
new TreeItem { NodeId = "D-PS", NodeText = "PS",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-PS", NodeText = "PS"}    },},
new TreeItem { NodeId = "D-QC", NodeText = "QC",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-QC", NodeText = "QC"}    ,
    new TreeItem { NodeId = "S-RD", NodeText = "RD"}    },},
new TreeItem { NodeId = "D-SHE", NodeText = "SHE",Child = new List<TreeItem>() {    new TreeItem { NodeId = "S-SHE", NodeText = "SHE"}  }},
new TreeItem { NodeId = "D-BC", NodeText = "BC",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-BC", NodeText = "BC"}    }},
new TreeItem { NodeId = "D-IT", NodeText = "IT",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-BAV", NodeText = "BAV"}  ,
    new TreeItem { NodeId = "S-INF", NodeText = "INF"}  },},
new TreeItem { NodeId = "D-IC", NodeText = "IC",Child = new List<TreeItem>() {  new TreeItem { NodeId = "S-IC", NodeText = "IC"}    }},
new TreeItem { NodeId = "D-ISO", NodeText = "ISO",Child = new List<TreeItem>() {    new TreeItem { NodeId = "S-ISO", NodeText = "ISO"}  }}
            },
        });
        TreeDataSource.Add(new TreeItem
        {
            NodeId = "MEPT",
            NodeText = "MEP Engineering-Plastics (Thailand) ",
            Child = new List<TreeItem>()
{
                new TreeItem { NodeId = "D-MKT", NodeText = "MKT",
                    Child = new List<TreeItem>()
{
                        new TreeItem { NodeId = "S-MKT", NodeText = "MKT" }
                    }
                },
                new TreeItem { NodeId = "D-BC", NodeText = "BC",
                    Child = new List<TreeItem>()
{
                        new TreeItem { NodeId = "S-BC", NodeText = "BC" }
                    }
                }
            },
        });
    }
    class TreeItem
    {
        public string NodeId { get; set; }
        public string NodeText { get; set; }
        public string Icon { get; set; }
        public bool Expanded { get; set; }
        public bool Selected { get; set; }
        public List<TreeItem> Child { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.PrOnWeb.Pages.AuthorityMap
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTreeViewFieldsSettings_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Navigations.TreeViewFieldsSettings<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "Id", __arg1);
        __builder.AddAttribute(__seq2, "Text", __arg2);
        __builder.AddAttribute(__seq3, "Expanded", __arg3);
        __builder.AddAttribute(__seq4, "Child", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
