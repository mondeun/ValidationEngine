using System;

namespace ValidationEngine
{
    public class MyDumbEmailException : Exception
    {
        public MyDumbEmailException() { }

        public MyDumbEmailException(string message) : base(message)
        {
        }

        public MyDumbEmailException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
