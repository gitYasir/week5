﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst {
    public partial class OrderDetail {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public int SupplierId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}
