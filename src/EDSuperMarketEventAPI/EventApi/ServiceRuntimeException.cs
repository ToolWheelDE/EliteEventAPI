﻿using System;
using System.Runtime.Serialization;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI
{
    [Serializable]
    internal class ServiceRuntimeException : Exception
    {
        public ServiceRuntimeException()
        {
        }

        public ServiceRuntimeException(string message) : base(message)
        {
        }

        public ServiceRuntimeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServiceRuntimeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}