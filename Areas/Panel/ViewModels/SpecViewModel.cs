﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semenarna_id2.Areas.Panel.ViewModels {
    public class SpecViewModel  {
        public string Name { get; set; }
        public string[] First { get; set; }
        public string[] Rest { get; set; }
        public int ItemsPerRow { get; set; }
    }
}
