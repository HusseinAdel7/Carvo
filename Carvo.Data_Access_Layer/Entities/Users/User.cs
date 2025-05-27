using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Enums;

namespace Carvo.Data_Access_Layer.Entities.Users
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; } = Role.Employee; 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Invoice> Invoices { get; set; } = new List<Invoice>(); 

    }
}
