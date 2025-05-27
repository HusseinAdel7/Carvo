using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvo.Data_Access_Layer.Entities.Users
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public double RemainingBalance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

    }
}
