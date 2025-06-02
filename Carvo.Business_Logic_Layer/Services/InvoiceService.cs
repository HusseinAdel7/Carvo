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
    public class InvoiceService: IInvoiceService
    {
        private readonly IGenericRepository<Invoice, int> _invoiceRepository;

        public InvoiceService(IGenericRepository<Invoice, int> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public Task<IEnumerable<Invoice>> GetAllInvoicesAsync()
        {
            return _invoiceRepository.GetAllAsync();
        }

        public Task<Invoice?> GetInvoiceByIdAsync(int id)
        {
            return _invoiceRepository.GetByIdAsync(id);
        }

        public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
        {
            if (invoice == null)
                throw new ArgumentNullException(nameof(invoice));

            invoice.InvoiceDate = DateTime.UtcNow;
            var addedInvoice = await _invoiceRepository.AddAsync(invoice);
            return addedInvoice;
        }

        public async Task<Invoice> UpdateInvoiceAsync(Invoice invoice)
        {
            if (invoice == null)
                throw new ArgumentNullException(nameof(invoice));

            var existingInvoice = await _invoiceRepository.GetByIdAsync(invoice.Id);
            if (existingInvoice == null)
                throw new KeyNotFoundException($"Invoice with ID {invoice.Id} not found.");

            // Update necessary fields
            
            existingInvoice.InvoiceNumber = invoice.InvoiceNumber;
            existingInvoice.RepairAmount = invoice.RepairAmount;
            existingInvoice.SaleAmount = invoice.SaleAmount;
            existingInvoice.InvoiceType = invoice.InvoiceType;
            existingInvoice.CustomerId = invoice.CustomerId;
            existingInvoice.UserId = invoice.UserId;


            var updatedInvoice = await _invoiceRepository.UpdateAsync(existingInvoice);
            return updatedInvoice;
        }

        public async Task<bool> DeleteInvoiceAsync(int id)
        {
            return await _invoiceRepository.DeleteAsync(id);
        }
    }
}
