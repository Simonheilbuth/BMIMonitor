﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BMIMonitor.Code;

namespace BMIMonitor
{
    public class Person
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI
        {
            get
            {
                var measurement = new Measurement(Weight, Height);
                return measurement.BMI;
            }
        }
    }
}