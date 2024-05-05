using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UnitTestProjectLibrary;

namespace UnitTestProjectLibrarytests
{
    public class BasicMathOperationsTests
    {

        [Fact]
        public void BasicAddShouldAddGivenNumbers()
        {
            BasicMathOperations basicAdd = new BasicMathOperations();
            double expected = 2;

            double actual = basicAdd.BasicAdd(1, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasicSubtractionShouldSubtractGivenNumbers()
        {
            BasicMathOperations basicSub = new BasicMathOperations();
            double expected = 2;

            double actual = basicSub.BasicSubtraction(4, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasicMultiplyShouldTimesGivenNumbers()
        {
            BasicMathOperations basicTimes = new BasicMathOperations();
            double expected = 2;

            double actual = basicTimes.BasicMultiply(2, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasicDivideShouldDivideGivenNumbers()
        {
            BasicMathOperations basicDivide = new BasicMathOperations();
            double expected = 5;

            double actual = basicDivide.BasicDivide(10, 2);

            Assert.Equal(expected, actual);
        }


    }
}
