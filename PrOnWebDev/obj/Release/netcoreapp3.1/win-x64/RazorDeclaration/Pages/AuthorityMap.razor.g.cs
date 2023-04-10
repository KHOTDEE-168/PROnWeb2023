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
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\AuthorityMap.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\AuthorityMap.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\AuthorityMap.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\AuthorityMap.razor"
       
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
    public async void nodeClicked(NodeClickEventArgs args)
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
#pragma warning restore 1591
