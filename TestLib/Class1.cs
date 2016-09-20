using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;


namespace TestLib
{
    public class Class1
    {
        [Test]
        public void Sum_2_5_7Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Add(2, 5);
            Assert.AreEqual(7, sum);
        }

        [Test]
        public void Sum_5_5_9Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Add(5, 5);
            Assert.AreEqual(9, sum);
        }

        [Test]
        public void Sum_10_10_20Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Add(10, 10);
            Assert.AreEqual(20, sum);
        }

        [Test]
        public void Sub_10_5_5Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Sub(10, 10);
            Assert.AreEqual(20, sum);
        }

        [Test]
        public void Sub_20_6_14Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Sub(20, 6);
            Assert.AreEqual(15, sum);
        }

        [Test]
        public void Sub_20_15_5Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Sub(20, 15);
            Assert.AreEqual(5, sum);
        }

        [Test]
        public void Mul_2_2_4Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Mul(2, 2);
            Assert.AreEqual(4, sum);
        }

        [Test]
        public void Mul_4_4_16Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Mul(4, 4);
            Assert.AreEqual(15, sum);
        }

        [Test]
        public void Mul_10_10_100Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Mul(10, 10);
            Assert.AreEqual(100, sum);
        }

        [Test]
        public void Div_10_5_2Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Div(10, 5);
            Assert.AreEqual(2, sum);
        }
        [Test]
        public void Div_20_5_4Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Div(20, 5);
            Assert.AreEqual(3, sum);
        }
        [Test]
        public void Div_50_5_10Returned()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            var sum = calc.Div(50, 5);
            Assert.AreEqual(10, sum);
        }
    }
}
