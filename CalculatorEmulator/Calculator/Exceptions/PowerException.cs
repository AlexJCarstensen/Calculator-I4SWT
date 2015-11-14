using System;
using System.Runtime.Serialization;

namespace Calculator.Exceptions
{
    [Serializable]
    public class PowerException : Exception
    {
        private double exp;
        private double x;

        public PowerException()
        {
        }

        public PowerException(string message) : base(message)
        {
        }

        public PowerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public PowerException(double x, double exp)
        {
            this.x = x;
            this.exp = exp;
        }

        protected PowerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}