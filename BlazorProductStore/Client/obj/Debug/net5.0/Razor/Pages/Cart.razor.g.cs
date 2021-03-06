#pragma checksum "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f9a824ad1846581a5b10ae2ca7444f382a8b72"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProductStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using BlazorProductStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using BlazorProductStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using BlazorProductStore.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using BlazorProductStore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using BlazorProductStore.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using BlazorProductStore.Shared.IdentityModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout2))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"ml-2\">Your cart</h2>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Quantity</th>\r\n            <th>Item</th>\r\n            <th class=\"text-right\">Price</th>\r\n            <th class=\"text-right\">Subtotal</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 19 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
         foreach(var cartline in state.CartLinesVMs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddAttribute(7, "class", "text-center");
            __builder.AddContent(8, 
#nullable restore
#line 22 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                             cartline.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "class", "text-left");
            __builder.AddContent(12, 
#nullable restore
#line 23 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                           cartline.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "text-right");
            __builder.AddContent(16, 
#nullable restore
#line 24 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                            cartline.Price.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "&nbsp;<span class=\"fa fa-rub\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "text-right");
            __builder.AddContent(21, 
#nullable restore
#line 25 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                             (cartline.Price * cartline.Quantity).ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "&nbsp;<span class=\"fa fa-rub\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "text-center");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                                                   e => Delete(e, cartline)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "tfoot");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "<td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "text-right");
            __builder.AddAttribute(36, "style", "font-weight:bold");
            __builder.AddContent(37, 
#nullable restore
#line 36 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                Total.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "text-center");
            __builder.AddAttribute(41, "style", "justify-content:center");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "class", "btn btn-info");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                        e => ContinueShopping(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "style", "font-weight:bold");
            __builder.AddContent(46, "Continue shopping");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-success ml-5");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                                                   e => Checkout(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Checkout");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-warning ml-5");
            __builder.AddAttribute(57, "style", "float:right");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
                                                                                       e => ClearCart(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "Clear cart");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Cart.razor"
       

    private decimal Total { get; set; } = 0;

    protected override void OnParametersSet()
    {
        foreach(var t in state.CartLinesVMs)
        {
            Total += t.Quantity * t.Price;
        }
    }

    private void ContinueShopping(MouseEventArgs e)
    {
        navigationManager.NavigateTo("/");
    }

    private async void ClearCart(MouseEventArgs e)
    {
        state.CartLinesVMs.Clear();
        StateHasChanged();
        await Task.Delay(2000);
        navigationManager.NavigateTo("/");
    }

    private void Delete(MouseEventArgs e, CartLineVM cartLine)
    {
        state.CartLinesVMs.Remove(cartLine);
        Total = 0;
        foreach (var t in state.CartLinesVMs)
        {
            Total += t.Quantity * t.Price;
        }
        StateHasChanged();
    }

    private void Checkout(MouseEventArgs e)
    {
        navigationManager.NavigateTo("/checkout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
    }
}
#pragma warning restore 1591
