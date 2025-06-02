using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;

namespace Carvo.Business_Logic_Layer.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly IGenericRepository<Customer, int> _customerRepository;

        public CustomerService(IGenericRepository<Customer, int> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return _customerRepository.GetAllAsync();
        }

        public Task<Customer?> GetCustomerByIdAsync(int id)
        {
            return _customerRepository.GetByIdAsync(id);
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            customer.CreatedAt = DateTime.UtcNow;
            var addedcustomer = await _customerRepository.AddAsync(customer);
            return addedcustomer;
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            var existingCustomer = await _customerRepository.GetByIdAsync(customer.Id);
            if (existingCustomer == null)
                throw new KeyNotFoundException($"Customer with ID {customer.Id} not found.");

            existingCustomer.Name = customer.Name;
            existingCustomer.PhoneNumber = customer.PhoneNumber;
            //existingCustomer.NationalId = customer.NationalId;

            var updatedCustomer = await _customerRepository.UpdateAsync(existingCustomer);
            return updatedCustomer;
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            return await _customerRepository.DeleteAsync(id);
        }
    }
}
