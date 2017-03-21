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

        protected abstract int underweightBMI { get; }

        protected abstract int overweightBMI { get; }

        protected Person(double height, double weight)
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
                bmiCategory = "太瘦";
            }
            else if (bmi > overweightBMI)
            {
                bmiCategory = "太胖";
            }

            return bmiCategory;
        }
    }

    public class Men : Person
    {
        public Men(double height, double weight) : base(height, weight)
        {

        }

        protected override int underweightBMI
        {
            get { return 20; }
        }

        protected override int overweightBMI
        {
            get { return 25; }
        }
    }

    public class Women : Person
    {
        public Women(double height, double weight) : base(height, weight)
        {

        }

        protected override int underweightBMI
        {
            get { return 18; }
        }

        protected override int overweightBMI
        {
            get { return 22; }
        }
    }
}
