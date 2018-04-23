using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, ICalculator calculator)
            => CalculateAverage(values, calculator.Calculate);

        public double CalculateAverage(List<double> values, Func<List<double>, double> calculator)
            => calculator(values);
    }
}
