#pragma checksum "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31711dc0521d711454d1690221691cd1ff59753"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>チェストアイテムの取得</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<label>チェストの座標</label>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group mb-3");
            __builder.AddMarkupContent(5, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"basic-addon1\">x</span></div>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "placeholder", "x座標");
            __builder.AddAttribute(10, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                      x

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => x = __value, x));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "input-group mb-3");
            __builder.AddMarkupContent(16, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"basic-addon1\">y</span></div>\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "y座標");
            __builder.AddAttribute(21, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                      y

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => y = __value, y));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "input-group mb-3");
            __builder.AddMarkupContent(27, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"basic-addon1\">z</span></div>\r\n        ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "placeholder", "z座標");
            __builder.AddAttribute(32, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                      z

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => z = __value, z));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "mt-3");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-outline-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                                                                        GetChestItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "アイテムの取得");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.AddMarkupContent(44, "<p>取得アイテム一覧が表示されます</p>");
#nullable restore
#line 34 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
 if (Items == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<p><em>Loading...</em></p>");
#nullable restore
#line 37 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "class", "table");
            __builder.AddMarkupContent(48, "<thead><tr><th>アイテム名</th>\r\n                <th>アイテムの数</th>\r\n                <th>アイテムスロット</th></tr></thead>\r\n        ");
            __builder.OpenElement(49, "tbody");
#nullable restore
#line 49 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
             foreach (var item in Items)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 52 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                         item.ItemName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 53 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                         item.ItemCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 54 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
                         item.ItemSlot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "F:\GitHub\Blazor_Minecraft\GetChestItems\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
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
