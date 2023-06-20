﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //ErişimBelirleyiciTürü DeğişkenTürü İsim {get set}
        [Key]
        public int CategoryID { get; set; }
        public string CtategoryNanem { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
