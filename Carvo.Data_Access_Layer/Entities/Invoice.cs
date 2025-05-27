using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;

namespace Carvo.Data_Access_Layer.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal RepairAmount { get; set; }
        public decimal SaleAmount { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        public InvoiceType InvoiceType { get; set; } = InvoiceType.None;


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();



    }
}
