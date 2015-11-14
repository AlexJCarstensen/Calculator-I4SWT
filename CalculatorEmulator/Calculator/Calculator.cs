using System;
using Calculator.Exceptions;

namespace Calculator
{
    /// <summary>
    /// This class have the following calculation abilities: Sum, Subtract, multiply and Power
    /// </summary>
    public class CalculatorEmulator : ICalculator
    {
        /// <summary>
        /// Returns the +sum of two variables
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Returns the - sum of two variables
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Returns the multiplication of two variables
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Returns a number raised to a specific variable. 
        /// If x or exp is below 0 throw exception
        /// </summary>
        /// <param name="x"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public double Power(double x, double exp)
        {
            if (x < 0 || exp < 0)
                throw new PowerException(x, exp);
            return Math.Pow(x, exp);
            
        }
    }
}
