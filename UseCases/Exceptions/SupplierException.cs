using System;

namespace UseCases.Exceptions
{
    public class SupplierException : Exception
    {
        public SupplierException(string message) : base(message)
        {

        }
    }
}
