using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    public class Person
    {
        public double Weight { get; set; }

        public double Height { get; set; }

        public Person(double height, double weight)
        {
            Weight = weight;

            Height = height / 100D;
        }

        public string CalculateBMI()
        {
            var BMI = this.Weight / (this.Height * this.Height);

            if (BMI < 20)
            {
                return "太瘦";
            }
            else if (BMI > 25)
            {
                return "太胖";
            }

            return "";
        }
    }
}
