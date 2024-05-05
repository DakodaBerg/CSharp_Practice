using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectLibrary
{
    public class BasicMathOperations
    {
        public double BasicAdd(double a, double b)
        {
            double output = 0;

            output = a + b;

            return output;
        }

        public double BasicSubtraction(double a, double b)
        {
            double output = 0;

            output = a - b;

            return output;
        }

        public double BasicDivide(double a, double b)
        {
            double output = 0;

            if (b != 0)
            {
                output = a / b;
            }

            return output;
        }

        public double BasicMultiply(double a, double b)
        {
            double output = 0;

            output = a * b;

            return output;
        }
    }
}
