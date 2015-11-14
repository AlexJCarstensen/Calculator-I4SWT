using System;
using System.Runtime.Serialization;

namespace Calculator
{
    [Serializable]
    public class DivisionException : Exception
    {
        public DivisionException()
        {
        }

        public DivisionException(string message) : base(message)
        {
        }

        public DivisionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DivisionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}