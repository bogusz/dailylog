using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyLog.Core;
using Moq;
using NUnit.Framework;
using Should;

namespace DailyLog.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        private Mock<IConsole> mockConsole;

        [SetUp]
        public void CreateCalculator()
        {
            mockConsole = new Mock<IConsole>();
            calc = new Calculator(mockConsole.Object);
        }

        [Test]
        public void Adding_an_empty_string_returns_zero()
        {            
            int sum = calc.Add("");
            sum.ShouldEqual(0);
        }

        [Test]
        public void Adding_one_returns_one()
        {         
            int sum = calc.Add("1");
            sum.ShouldEqual(1);
        }

        [Test]
        public void Adding_two_returns_two()
        {            
            int sum = calc.Add("2");
            sum.ShouldEqual(2);
        }

        [Test]
        public void Adding_one_comma_two_returns_three()
        {         
            int sum = calc.Add("1,2");
            sum.ShouldEqual(3);
        }

        [Test]
        public void Adding_one_comma_two_comma_three_returns_six()
        {
            int sum = calc.Add("1,2,3");
            sum.ShouldEqual(6);
        }

        [Test]
        public void Adding_negative_number_throws_exception()
        {
            Assert.Throws<InvalidOperationException>(() => calc.Add("-1"));
        }

        [Test]
        public void Adding_one_writes_one_to_the_console()
        {
            int sum = calc.Add("1");

            mockConsole.Verify(c => c.WriteLine(1));
        }

    }
}
