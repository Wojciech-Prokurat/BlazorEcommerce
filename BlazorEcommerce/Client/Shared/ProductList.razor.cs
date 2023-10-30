namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        protected override void OnInitialized()
        {
            productService.ProductsChanged += StateHasChanged;
        }

        public void Dispose()
        {
            productService.ProductsChanged -= StateHasChanged;
        }
    }
}
