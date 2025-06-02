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
    public class VehicleService : IVehicleService
    {
        private readonly IGenericRepository<Vehicle, int> _vehicleRepository;

        public VehicleService(IGenericRepository<Vehicle, int> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return _vehicleRepository.GetAllAsync();
        }

        public Task<Vehicle?> GetVehicleByIdAsync(int id)
        {
            return _vehicleRepository.GetByIdAsync(id);
        }

        public async Task<Vehicle> AddVehicleAsync(Vehicle vehicle)
        {
            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));

            vehicle.CreatedAt = DateTime.UtcNow;
            var addedVehicle = await _vehicleRepository.AddAsync(vehicle);
            return addedVehicle;
        }

        public async Task<Vehicle> UpdateVehicleAsync(Vehicle vehicle)
        {
            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));

            var existingVehicle = await _vehicleRepository.GetByIdAsync(vehicle.Id);
            if (existingVehicle == null)
                throw new KeyNotFoundException($"Vehicle with ID {vehicle.Id} not found.");

            existingVehicle.Name = vehicle.Name;
            existingVehicle.Model = vehicle.Model;
            existingVehicle.PlateNumber = vehicle.PlateNumber;
            existingVehicle.CustomerId = vehicle.CustomerId;

            var updatedVehicle = await _vehicleRepository.UpdateAsync(existingVehicle);
            return updatedVehicle;
        }

        public async Task<bool> DeleteVehicleAsync(int id)
        {
            return await _vehicleRepository.DeleteAsync(id);
        }
    }
}
