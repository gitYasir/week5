using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst {
    public partial class Supplier {


        public int SupplierId { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierCountry { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
