#pragma checksum "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d999dbe7b90669f23cf94f6de4c642aa31babf7f"
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
#line 4 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
using BlazorPagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "<thead><tr><th>ID</th>\r\n            <th>Name</th>\r\n            <th>Category</th>\r\n            <th>Price</th>\r\n            <th>Edit</th>\r\n            <th>Delete</th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 27 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
         if (ProductsData.Results != null && ProductsData.Results.Length > 0)
        {
            foreach (var product in ProductsData.Results)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 32 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                         product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 33 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 34 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                         product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 35 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                         product.Price.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                                                           _ => EditProduct(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                                                          e => DeleteProduct(e, product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "mt-2");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary float-left");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                                           e => CreateProduct(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenComponent<BlazorPagination.BlazorPager>(36);
            __builder.AddAttribute(37, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                               ProductsData.CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "PageCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                             ProductsData.PageCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "VisiblePages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 53 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                visiblePages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "ShowFirstLast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ShowPageNumbers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "FirstText", "«");
            __builder.AddAttribute(43, "LastText", "»");
            __builder.AddAttribute(44, "NextText", "›");
            __builder.AddAttribute(45, "PreviousText", "‹");
            __builder.AddAttribute(46, "OnPageChanged", new System.Func<System.Int32, System.Threading.Tasks.Task>(
#nullable restore
#line 60 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                                  async e => { _page = e; await GetData(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n");
            __Blazor.BlazorProductStore.Client.Pages.Admin.Products.TypeInference.CreateCascadingValue_0(__builder, 48, 49, 
#nullable restore
#line 64 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
                        Message

#line default
#line hidden
#nullable disable
            , 50, (__builder2) => {
                __builder2.OpenComponent<BlazorProductStore.Client.Pages.MessageModal>(51);
                __builder2.AddAttribute(52, "CloseModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 65 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
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
#line 68 "C:\Users\DENIS\source\repos\BlazorProductStore\BlazorProductStore\Client\Pages\Admin\Products.razor"
       

    private PagedResult<Product> ProductsData { get; set; } = new PagedResult<Product>();
    private int pageSize = 4;
    private int _page = 1;
    private int visiblePages = 0;
    public Product products = new Product();
    private string Message { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        state.AdminProducts = await productService.GetProductsAsync();
        visiblePages = (state.AdminProducts.Count / pageSize) + 1;
        await GetData();
    }

    private async Task GetData()
    {
        ProductsData = GetProduct(_page, pageSize);
        await Task.Delay(50);
        StateHasChanged();
    }

    private PagedResult<Product> GetProduct(int page, int pageSize)
    {
        return state.AdminProducts.AsQueryable().ToPagedResult(page, pageSize);
    }

    private void EditProduct(Product product)
    {
        var id = product.Id;
        navigationManager.NavigateTo("/admin/editor/" + id);
    }

    private async Task DeleteProduct(MouseEventArgs e, Product product)
    {
        var response = await adminService.DeleteProductAsync(product);
        if (response.IsSuccessStatusCode)
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");
        }
    }

    private void CreateProduct(MouseEventArgs e)
    {
        navigationManager.NavigateTo("/admin/create");
    }

    private async Task CloseMessageModal()
    {
        state.AdminProducts = new List<Product>();
        state.AdminProducts = await productService.GetProductsAsync();
        await GetData();
        await jsRuntime.InvokeVoidAsync("HideMessageModal");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminService adminService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
namespace __Blazor.BlazorProductStore.Client.Pages.Admin.Products
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