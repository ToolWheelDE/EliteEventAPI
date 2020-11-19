using EliteEventAPI.Diagnostics.Logging;
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 1591

namespace Pandora
{
    public static class Logger
    {
        public static void Trace(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Trace, message);
        }

        public static void Debug(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Debug, message);
        }

        public static void Normal(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Normal, message);
        }

        public static void Warning(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Warning, message);
        }

        public static void Error(string message)
        {
            LoggerManager.LogMessage(LoggerMessageType.Error, message);
        }

        public static void Exception(Exception ex, [CallerMemberName] string membername = "", [CallerLineNumber] int linenumber = 0, [CallerFilePath] string file = "")
        {
            LoggerManager.LogException(ex, membername, linenumber, file);
        }

        public static void BeginProgress(float count, string message)
        {
            LoggerManager.BeginProgress(count, message);
        }

        public static void UpdateProgress(int count)
        {
            LoggerManager.UpdateProgress(count);
        }

        public static void EndProgress(bool abort)
        {
            LoggerManager.EndProgress(abort);
        }

        public static void BeginState(string message)
        {
            LoggerManager.BeginState(message);
        }

        public static void EndState(LoggerStateResult result)
        {
            LoggerManager.EndState(result);
        }
    }
}
