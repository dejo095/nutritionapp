﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLibrary.Models
{
    public class TypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Group_Id { get; set; }
        public string MaxDV { get; set; }
        public string Notes { get; set; }
    }
}
