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
#line 1 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

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
#line 12 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\Utilities\FileBrowser.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\Utilities\FileBrowser.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\Utilities\FileBrowser.razor"
           [Authorize(Roles = "Administrators")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/FileBrowser")]
    public partial class FileBrowser : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PR2023New\PROnWeb2023\PrOnWebDev\Pages\Utilities\FileBrowser.razor"
       
    public class DataTable
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public DateTime FileDate { get; set; }
    }

    DataTable ShowContent;
    List<DataTable> FolderContents;
    List<DataTable> ArchiveFolderContents;
    FileInfo fInfo;

    private List<DataTable> LoadFolderContent(string folder)
    {
        var folderContent = new List<DataTable>();
        string[] RawFiles = Directory.GetFiles(folder, "*.*");
        if (RawFiles.Count() > 0)
        {
            foreach (var rawFile in RawFiles)
            {
                fInfo = new FileInfo(rawFile);
                ShowContent = new DataTable()
                {
                    FileName = fInfo.Name,
                    FileSize = fInfo.Length,
                    FileDate = fInfo.CreationTime
                };
                folderContent.Add(ShowContent);
            }
        }
        return folderContent;

    }

    protected override void OnInitialized()
    {
        var filePath = _env.WebRootPath + "\\CSVin";
        FolderContents = LoadFolderContent(filePath);
        filePath = _env.WebRootPath + "\\RawDataArchive";
        ArchiveFolderContents = LoadFolderContent(filePath);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env { get; set; }
    }
}
#pragma warning restore 1591
