using System;

namespace UseCases.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message)
        {

        }
    }
}
