using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;

namespace Carvo.Business_Logic_Layer.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product, int> _productRepository;

        public ProductService(IGenericRepository<Product, int> productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return _productRepository.GetAllAsync();
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            return _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            product.ImportDate = DateTime.UtcNow;
            var addedProduct = await _productRepository.AddAsync(product);
            return addedProduct;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            var existingProduct = await _productRepository.GetByIdAsync(product.Id);
            if (existingProduct == null)
                throw new KeyNotFoundException($"Product with ID {product.Id} not found.");

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.SupplierId = product.SupplierId;


            var updatedProduct = await _productRepository.UpdateAsync(existingProduct);
            return updatedProduct;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }
    }
}
