﻿using System.Linq;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                response.Success = false;
                response.Message = "Sorry, not found";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>();
            var products = await _context.Products
                .Where(x => x.Category.Url.ToLower().Equals(categoryUrl))
                .ToListAsync();
            if (products == null)
            {
                response.Success = false;
                response.Message = "Sorry, not found";
            }
            else
            {
                response.Data = products;
            }
            return response;
        }
    }
}
