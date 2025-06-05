using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;

namespace Carvo.Business_Logic_Layer.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly IGenericRepository<Supplier, int> _supplierRepository;

        public SupplierService(IGenericRepository<Supplier, int> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return _supplierRepository.GetAllAsync();
        }

        public Task<Supplier?> GetSupplierByIdAsync(int id)
        {
            return _supplierRepository.GetByIdAsync(id);
        }

        public async Task<Supplier> AddSupplierAsync(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));

            supplier.CreatedAt = DateTime.UtcNow;
            var addedSupplier = await _supplierRepository.AddAsync(supplier);
            return addedSupplier;
        }

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));

            var existingSupplier = await _supplierRepository.GetByIdAsync(supplier.Id);
            if (existingSupplier == null)
                throw new KeyNotFoundException($"Supplier with ID {supplier.Id} not found.");

            existingSupplier.Name = supplier.Name;
            existingSupplier.PhoneNumber = supplier.PhoneNumber;
            existingSupplier.Address = supplier.Address;
            existingSupplier.ComapayName = supplier.ComapayName;
            existingSupplier.RemainingBalance = supplier.RemainingBalance;
          


            var updatedSupplier = await _supplierRepository.UpdateAsync(existingSupplier);
            return updatedSupplier;
        }

        public async Task<bool> DeleteSupplierAsync(int id)
        {
            return await _supplierRepository.DeleteAsync(id);
        }
    }
}
