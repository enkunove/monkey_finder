﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monkey_finder.Lib.Model
{
    public class MonkeyModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public double Latitude { get; set; }

        public double Longtitude { get; set; }
    }
}
