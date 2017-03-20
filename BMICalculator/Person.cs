using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    public abstract class Person
    {
        public double Weight { get; private set; }

        public double Height { get; private set; }

        protected int underweightBMI { get; set; }

        protected int overweightBMI { get; set; }

        public Person(double height, double weight)
        {
            Weight = weight;

            Height = height / 100D;
        }

        public string CalculateBMI()
        {
            var bmi = Weight / (Height * Height);

            var bmiCategory = "適中";

            if (bmi < underweightBMI)
            {
                return "太瘦";
            }
            else if (bmi > overweightBMI)
            {
                return "太胖";
            }

            return bmiCategory;
        }
    }

    public class Men : Person
    {
        public Men(double height, double weight) : base(height, weight)
        {
            underweightBMI = 20;

            overweightBMI = 25;
        }
    }

    public class Women : Person
    {
        public Women(double height, double weight) : base(height, weight)
        {

        }
    }
}
