using Calculator;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalculatorEmulator();
        }
#region Add
        [Test]
        public void Add_aIs2bIs2_Return4()
        {
            var result = _calculator.Add(2, 2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Add_aIs2bIsMinus2_Return0()
        {
            var result = _calculator.Add(2, -2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_aIs2bIsMinus3_ReturnMinus1()
        {
            var result = _calculator.Add(2, -3);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Add_aIsMinus2bIs2_Return0()
        {
            var result = _calculator.Add(-2, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_aIsMinus3bIs2_ReturnMinus1()
        {
            var result = _calculator.Add(-3, 2);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Add_aIsMinus3bIsMinus2_ReturnMinus5()
        {
            var result = _calculator.Add(-3, -2);
            Assert.That(result, Is.EqualTo(-5));
        }
        #endregion
#region Subtract
        [Test]
        public void Subtract_aIs2bIs2_Return0()
        {
            var result = _calculator.Subtract(2, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Subtract_aIs2bIsMinus2_Return4()
        {
            var result = _calculator.Subtract(2, -2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Subtract_aIs2bIsMinus3_ReturnMinus5()
        {
            var result = _calculator.Subtract(2, -3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_aIsMinus2bIs2_ReturnMinus4()
        {
            var result = _calculator.Subtract(-2, 2);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Subtract_aIsMinus3bIs2_ReturnMinus5()
        {
            var result = _calculator.Subtract(-3, 2);
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Subtract_aIsMinus3bIsMinus2_Return5()
        {
            var result = _calculator.Subtract(-3, -2);
            Assert.That(result, Is.EqualTo(-1));
        }
#endregion

    }
}
