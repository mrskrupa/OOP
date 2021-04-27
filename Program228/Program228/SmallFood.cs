using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program228
{
    public class SmallFood : CalculateFood
    {
        private double _coefficient = 1.2;
        public override double CalculateGrams()
        {
            if (Weight < 5)
            {
                _coefficient = 1.4;
                return (Height + Weight) * Age * _coefficient;
            }
            return (Height + Weight) * Age * _coefficient;
        }
    }
}
