using BlazorProductStore.Shared.ViewModels;
using System.Collections.Generic;

namespace BlazorProductStore.Shared.Models
{
    public class State
    {
        public List<Product> Products { get; set; }

        public List<Product> AdminProducts { get; set; }
        public List<CartLineVM> CartLinesVMs { get; set; } = new List<CartLineVM>();
    }
}
