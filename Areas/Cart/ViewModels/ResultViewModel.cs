﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semenarna_id2.Areas.Cart.ViewModels {
    public class ResultViewModel {
        public string OrderId { get; set; }
        public string OrderStatus { get; set; }
        public string Message { get; set; }
        public string EmailSent { get; set; }
    }
}