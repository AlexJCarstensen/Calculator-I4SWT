using Calculator;
using Calculator.Exceptions;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private ICalculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new CalculatorEmulator();
        }
        #region Add
        [Test]
        public void Add_aIs2bIs2_Return4()
        {
            var result = _uut.Add(2, 2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Add_aIs2bIsMinus2_Return0()
        {
            var result = _uut.Add(2, -2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_aIs2bIsMinus3_ReturnMinus1()
        {
            var result = _uut.Add(2, -3);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Add_aIsMinus2bIs2_Return0()
        {
            var result = _uut.Add(-2, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_aIsMinus3bIs2_ReturnMinus1()
        {
            var result = _uut.Add(-3, 2);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Add_aIsMinus3bIsMinus2_ReturnMinus5()
        {
            var result = _uut.Add(-3, -2);
            Assert.That(result, Is.EqualTo(-5));
        }
        #endregion
        #region Subtract
        [Test]
        public void Subtract_aIs2bIs2_Return0()
        {
            var result = _uut.Subtract(2, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Subtract_aIs2bIsMinus2_Return4()
        {
            var result = _uut.Subtract(2, -2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Subtract_aIs2bIsMinus3_ReturnMinus5()
        {
            var result = _uut.Subtract(2, -3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_aIsMinus2bIs2_ReturnMinus4()
        {
            var result = _uut.Subtract(-2, 2);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Subtract_aIsMinus3bIs2_ReturnMinus5()
        {
            var result = _uut.Subtract(-3, 2);
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Subtract_aIsMinus3bIsMinus2_Return5()
        {
            var result = _uut.Subtract(-3, -2);
            Assert.That(result, Is.EqualTo(-1));
        }
        #endregion
        #region Multiply
        [Test]
        public void Multiply_aIs2bIs2_Return4()
        {
            var result = _uut.Multiply(2, 2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Multiply_aIs2bIsMinus2_ReturnMinus4()
        {
            var result = _uut.Multiply(2, -2);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Multiply_aIs2bIsMinus3_ReturnMinus6()
        {
            var result = _uut.Multiply(2, -3);
            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void Multiply_aIsMinus2bIs2_ReturnMinus4()
        {
            var result = _uut.Multiply(-2, 2);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Multiply_aIsMinus3bIs2_ReturnMinus6()
        {
            var result = _uut.Multiply(-3, 2);
            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void Multiply_aIsMinus3bIsMinus2_Return6()
        {
            var result = _uut.Multiply(-3, -2);
            Assert.That(result, Is.EqualTo(6));
        }
        #endregion
        #region Power
        [Test]
        public void Power_aIs2bIs2_Return4()
        {
            var result = _uut.Power(2, 2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Power_aIs2bIsMinus2_ReturnMinus4()
        {
           Assert.Throws<PowerException>(() => _uut.Power(2,-2));
        }

        
        [Test]
        public void Power_aIsMinus2bIs2_ReturnMinus4()
        {
            Assert.Throws<PowerException>(() => _uut.Power(-2, 2));
        }

        [Test]
        public void Power_aIsMinus3bIsMinus2_Return6()
        {
            Assert.Throws<PowerException>(() => _uut.Power(-3, -2));
        }
        #endregion
        #region Division
        [Test]
        public void Division_aIs2bIs2_Return1()
        {
            var result = _uut.Division(2, 2);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Division_aIs2bIsMinus2_ReturnMinus1()
        {
            var result = _uut.Division(2, -2);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Division_aIsMinus2bIs2_ReturnMinus4()
        {
            var result = _uut.Division(-2, 2);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Division_aIsMinus3bIsMinus2_Return6()
        {
            var result = _uut.Division(-5, -2);
            Assert.That(result, Is.EqualTo(2.5));
        }

        [Test]
        public void Division_aIsZerobIs2_ThrowException()
        {
            Assert.Throws<DivisionException>(() => _uut.Division(0, 2));
        }

        [Test]
        public void Division_aIs2bIsZero_ThrowException()
        {
            Assert.Throws<DivisionException>(() => _uut.Division(2, 0));
        }
        [Test]
        public void Division_aAndbIsZero_ThrowException()
        {
            Assert.Throws<DivisionException>(() => _uut.Division(0, 0));
        }
        #endregion
    }
}
