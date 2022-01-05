using System;


namespace SegundaFase.Business
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
