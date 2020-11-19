using System;
using System.Runtime.CompilerServices;

namespace EliteEventAPI.Diagnostics.Logging
{
    public sealed class ClassLogger
    {
        public string InstanceName { get; private set; }

        public ClassLogger(object instance)
        {
            ResolveTypeName(instance.GetType());
        }

        private void ResolveTypeName(Type type)
        {
            InstanceName = type.Name;
        }

        public void Trace(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Trace, "[" + InstanceName + "] " + message);
        }

        public void Debug(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Debug, "[" + InstanceName + "] " + message);
        }

        public void Normal(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Normal, "[" + InstanceName + "] " + message);
        }

        public void Warning(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Warning, "[" + InstanceName + "] " + message);
        }

        public void Error(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Error, "[" + InstanceName + "] " + message);
        }

        public void Exception(Exception ex, [CallerMemberName] string membername = "", [CallerLineNumber] int linenumber = 0, [CallerFilePath] string file = "")
        {
            LoggerManager.LogException(ex, membername, linenumber, file);
        }
    }
}
