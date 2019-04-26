using System;
using System.Runtime.Serialization;

namespace MeuECommerce.Repositories
{
    [Serializable]
    internal class ArgumentExecption : Exception
    {
        public ArgumentExecption()
        {
        }

        public ArgumentExecption(string message) : base(message)
        {
        }

        public ArgumentExecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentExecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}