namespace BlazorProductStore.Shared.ViewModels
{
    public class CartLineVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
