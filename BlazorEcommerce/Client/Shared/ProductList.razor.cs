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
        private string GetPriceText(Product product)
        {
            var variants = product.Variants;
            if(variants.Count == 0)
            {
                return string.Empty;
            }
            else if (variants.Count == 1)
            {
                 return $"{variants[0].Price} zł";
            }
            decimal minPrice = variants.Min(v => v.Price);
            return $"Starting at {minPrice} zł";
        }
    }

}
