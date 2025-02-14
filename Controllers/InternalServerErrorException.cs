﻿using System.Runtime.Serialization;

namespace CoreSample.Controllers
{
    [Serializable]
    internal class InternalServerErrorException : Exception
    {
        public InternalServerErrorException()
        {
        }

        public InternalServerErrorException(string? message) : base(message)
        {
        }

        public InternalServerErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InternalServerErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}