using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;

namespace Carvo.Business_Logic_Layer.IServices
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        Task<Vehicle?> GetVehicleByIdAsync(int id);
        Task<Vehicle> AddVehicleAsync(Vehicle vehicle);
        Task<Vehicle> UpdateVehicleAsync(Vehicle vehicle);
        Task<bool> DeleteVehicleAsync(int id);
    }
}
