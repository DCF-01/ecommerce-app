﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models {
    public class CartProduct {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string[] Variations { get; set; }
        
    }
}
