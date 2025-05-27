using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvo.Data_Access_Layer.Entities
{
    public class InvoiceProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int InvoiceId { get; set; }
        public int ProductId { get; set; }

        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
