using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Entities.Users;

namespace Carvo.Data_Access_Layer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ImportDate { get; set; } = DateTime.Now;


        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        public ICollection<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();
        


    }
}
