#pragma checksum "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32c84ca6ab6d546c4f6ef32c54e0640f510c0e68"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProductStore.Client.Pages.Admin
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
#nullable restore
#line 5 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorProductStore.Client.Pages.Admin.OrderTable>(0);
            __builder.AddAttribute(1, "TableTitle", "Unshipped Orders");
            __builder.AddAttribute(2, "CompletedOrders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorProductStore.Shared.ViewModels.CompletedOrder>>(
#nullable restore
#line 9 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                                                           UnshippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonLabel", "Ship");
            __builder.AddAttribute(4, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 10 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                                              ShipOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<BlazorProductStore.Client.Pages.Admin.OrderTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Shipped Orders");
            __builder.AddAttribute(8, "CompletedOrders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorProductStore.Shared.ViewModels.CompletedOrder>>(
#nullable restore
#line 12 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                                                         ShippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Reset");
            __builder.AddAttribute(10, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 13 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                                               ResetOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                                         e => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Refresh Data");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __Blazor.BlazorProductStore.Client.Pages.Admin.Orders.TypeInference.CreateCascadingValue_0(__builder, 17, 18, 
#nullable restore
#line 17 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                        Message

#line default
#line hidden
#nullable disable
            , 19, (__builder2) => {
                __builder2.OpenComponent<BlazorProductStore.Client.Pages.MessageModal>(20);
                __builder2.AddAttribute(21, "CloseModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 18 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
                               CloseMessageModal

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Orders.razor"
       

    private List<CompletedOrder> AllOrders { get; set; } = new List<CompletedOrder>();
    private List<CompletedOrder> UnshippedOrders { get; set; } = new List<CompletedOrder>();
    private List<CompletedOrder> ShippedOrders { get; set; } = new List<CompletedOrder>();
    private string Message { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        await UpdateData();
    }

    private async Task UpdateData()
    {
        AllOrders = await adminService.GetAllOrdersAsync();
        UnshippedOrders = AllOrders.Where(x => x.Shipped == false).ToList();
        ShippedOrders = AllOrders.Where(x => x.Shipped == true).ToList();
    }

    private async Task ShipOrder(int id) => await UpdateOrder(id, true);
    private async Task ResetOrder(int id) => await UpdateOrder(id, false);

    private async Task UpdateOrder(int id, bool shipValue)
    {
        var completedOrder = AllOrders.Where(x => x.OrderId == id).FirstOrDefault();
        completedOrder.Shipped = shipValue;
        var response = await adminService.UpdateOrderAsync(completedOrder);
        if (response.IsSuccessStatusCode)
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");
        }
        else
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");
        }
    }

    private void CloseMessageModal()
    {
        jsRuntime.InvokeVoidAsync("HideMessageModal");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminService adminService { get; set; }
    }
}
namespace __Blazor.BlazorProductStore.Client.Pages.Admin.Orders
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
