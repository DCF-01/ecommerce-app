﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Areas.Panel.ViewModels {
    public class PromotionViewModel {
        public int PromotionId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Price { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }
        public IFormFile Img { get; set; }
        public string GetImg { get; set; }
        public bool Active { get; set; }
        public double DateToMil { get; set; }

    }
}
