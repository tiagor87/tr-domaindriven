using System;

namespace Seedwork.DomainDriven.Core
{
    [Serializable]
    public class DomainException : Exception
    {
        public DomainException(string message, Exception exception) : base(message, exception)
        {
        }

        public DomainException(string message) : base(message)
        {
        }
    }
}