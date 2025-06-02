using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities;

namespace Carvo.Business_Logic_Layer.IServices
{
    public interface IInvoiceProductService
    {
        Task<IEnumerable<InvoiceProduct>> GetAllInvoiceProductsAsync();
        Task<InvoiceProduct?> GetInvoiceProductByIdAsync(int id);
        Task<InvoiceProduct> AddInvoiceProductAsync(InvoiceProduct invoiceProduct);
        Task<InvoiceProduct> UpdateInvoiceProductAsync(InvoiceProduct invoiceProduct);
        Task<bool> DeleteInvoiceProductAsync(int id);
    }
}
