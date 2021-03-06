// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 7 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\CreateProduct.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\CreateProduct.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/create")]
    public partial class CreateProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\CreateProduct.razor"
       

    private Product Products = new Product();
    private List<string> Categories = new List<string>();
    private string Message { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        Categories = state.AdminProducts.Select(x => x.Category).Distinct().ToList();
        await Task.Delay(50);
    }

    private async Task CreateProductAsync()
    {
        var response = await adminService.CreateProductAsync(Products);
        if (response.IsSuccessStatusCode)
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");
        }
    }

    private void Cancel(MouseEventArgs e)
    {
        navigationManager.NavigateTo("/admin/products");
    }

    private void CloseMessageModal()
    {
        jsRuntime.InvokeVoidAsync("HideMessageModal");
        navigationManager.NavigateTo("/admin/products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminService adminService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
    }
}
#pragma warning restore 1591
