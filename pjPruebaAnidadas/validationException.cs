using System.Runtime.Serialization;

namespace pjPruebaAnidadas
{
    [Serializable]
    internal class validationException : Exception
    {
        public validationException()
        {
        }

        public validationException(string? message) : base(message)
        {
        }

        public validationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected validationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}