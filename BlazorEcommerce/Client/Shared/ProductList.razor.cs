using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        private static List<Product> products = new List<Product>();            
        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            products = result != null && result.Data != null ? result.Data : new List<Product>();
        }
    }
}
