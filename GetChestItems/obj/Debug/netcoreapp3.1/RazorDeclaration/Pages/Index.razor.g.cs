// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GetChestItems.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using GetChestItems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using GetChestItems.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\GitHub\Blazor_Minecraft\GetChestItems\_Imports.razor"
using CoreRCON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
using GetChestItems.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
      
    private int x;
    private int y;
    private int z;

    private ChestItems[] Items;

    protected override async Task OnInitializedAsync()
    {
        Items = await ItemService.GetItems(x, y, z);
    }

    private async Task GetChestItems()
    {
        //await ItemService.GetItems(x, y, z);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChestItemService ItemService { get; set; }
    }
}
#pragma warning restore 1591