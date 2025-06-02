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
    public class InvoiceProductService : IInvoiceProductService
    {
        private readonly IGenericRepository<InvoiceProduct, int> _invoiceProductRepository;

        public InvoiceProductService(IGenericRepository<InvoiceProduct, int> invoiceProductRepository)
        {
            _invoiceProductRepository = invoiceProductRepository;
        }

        public Task<IEnumerable<InvoiceProduct>> GetAllInvoiceProductsAsync()
        {
            return _invoiceProductRepository.GetAllAsync();
        }

        public Task<InvoiceProduct?> GetInvoiceProductByIdAsync(int id)
        {
            return _invoiceProductRepository.GetByIdAsync(id);
        }

        public async Task<InvoiceProduct> AddInvoiceProductAsync(InvoiceProduct invoiceProduct)
        {
            if (invoiceProduct == null)
                throw new ArgumentNullException(nameof(invoiceProduct));

            var addedInvoiceProduct = await _invoiceProductRepository.AddAsync(invoiceProduct);
            return addedInvoiceProduct;
        }

        public async Task<InvoiceProduct> UpdateInvoiceProductAsync(InvoiceProduct invoiceProduct)
        {
            if (invoiceProduct == null)
                throw new ArgumentNullException(nameof(invoiceProduct));

            var existingInvoiceProduct = await _invoiceProductRepository.GetByIdAsync(invoiceProduct.Id);
            if (existingInvoiceProduct == null)
                throw new KeyNotFoundException($"InvoiceProduct with ID {invoiceProduct.Id} not found.");

            // Update necessary fields
            existingInvoiceProduct.ProductId = invoiceProduct.ProductId;
            existingInvoiceProduct.InvoiceId = invoiceProduct.InvoiceId;
            existingInvoiceProduct.Quantity = invoiceProduct.Quantity;

            var updatedInvoiceProduct = await _invoiceProductRepository.UpdateAsync(existingInvoiceProduct);
            return updatedInvoiceProduct;
        }

        public async Task<bool> DeleteInvoiceProductAsync(int id)
        {
            return await _invoiceProductRepository.DeleteAsync(id);
        }
    }
}
