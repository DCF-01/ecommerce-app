﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models {
    public class Image {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public byte[] Img { get; set; }
    }
}
