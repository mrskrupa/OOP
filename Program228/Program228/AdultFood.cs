using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program228
{
    public class AdultFood : CalculateFood
    {
        private double _coefficient = 1.8;
        public override double CalculateGrams()
        {
            if (Weight < 18)
            {
                _coefficient = 1.9;
                return (Height + Weight) * Age * _coefficient;
            }
            return (Height + Weight) * Age * _coefficient;
        }
    }
}
