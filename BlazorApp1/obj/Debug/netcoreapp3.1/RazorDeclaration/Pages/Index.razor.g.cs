// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\GitHub\Blazor_Minecraft\BlazorApp1\_Imports.razor"
using CoreRCON;

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
#line 15 "F:\GitHub\Blazor_Minecraft\BlazorApp1\Pages\Index.razor"
      
    static IPAddress ipaddress = IPAddress.Parse("127.0.0.1");
    static ushort port = 25575;
    static string password = "minecraft";
    static RCON rcon = new RCON(ipaddress, port, password);

    private string command; //Web UI

    private async Task Send()
    {
        await rcon.ConnectAsync();

        var weather_result = await rcon.SendCommandAsync(command);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
