using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program228
{
    private double _coefficient = 1.5;
    public override double CalculateGrams()
    {
        if (Weight < 13)
        {
            _coefficient = 1.7;
            return (Height + Weight) * Age * _coefficient;
        }
        return (Height + Weight) * Age * _coefficient;
    }
}
}
