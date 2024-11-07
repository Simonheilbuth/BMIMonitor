using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMonitor.Code
{
    
        public struct Measurement
        {
            public double BMI { get; private set; }

            public Measurement(double weight, double height)
            {
                BMI = CalculateBMI(weight, height);
            }

            private static double CalculateBMI(double weight, double height)
            {
                return weight / (height * height);
            }
        }
    }
