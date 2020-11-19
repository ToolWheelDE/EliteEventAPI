using System;

namespace EliteEventAPI.Diagnostics.Logging.Targets
{
    /// <summary>
    /// Löst bei einer Logger Nachricht aus
    /// </summary>
    /// <param name="type"></param>
    /// <param name="message"></param>
    public delegate void LoggerMessageDelegate(LoggerMessageType type, string message);

    /// <summary>
    /// Löst bei einer Ausnahme aus
    /// </summary>
    /// <param name="ex"></param>
    /// <param name="membername"></param>
    /// <param name="linenumber"></param>
    /// <param name="file"></param>
    public delegate void LoggerExceptionDelegate(Exception ex, string membername, int linenumber, string file);

    /// <summary>
    /// Löst aus wenn eine neue Prozess gestatet wird
    /// </summary>
    /// <param name="count"></param>
    /// <param name="message"></param>
    public delegate void LoggerBeginProgressDelegate(float count, string message);

    /// <summary>
    /// Löst aus wenn ein Prozess aktualisiert wird
    /// </summary>
    /// <param name="percent"></param>
    public delegate void LoggerUpdateProgressDelegate(float percent);

    /// <summary>
    /// Löst aus wenn ein Prozess beendet wird
    /// </summary>
    /// <param name="abort"></param>
    public delegate void LoggerEndProgressDelegate(bool abort);

    /// <summary>
    /// Löst aus wenn ein Status gestartet wird
    /// </summary>
    /// <param name="message"></param>
    public delegate void LoggerBeginStateDelegate(string message);

    /// <summary>
    /// Löst aus wenn ein Status beendet wird
    /// </summary>
    /// <param name="result"></param>
    public delegate void LoggerEndStateDelegate(LoggerStateResult result);

    /// <summary>
    /// Stellt ein Loggerziel dar, das alle Logger Ereignisse an Delegates weiterleitet
    /// </summary>
    public sealed class DelegateLoggerTarget : LoggerTarget
    {
        /// <summary>
        /// Löst bei einer Logger Nachricht aus
        /// </summary>
        public event LoggerMessageDelegate LoggerMessage;

        /// <summary>
        /// Löst bei einer Ausnahme aus
        /// </summary>
        public event LoggerExceptionDelegate LoggerException;

        /// <summary>
        /// Löst aus wenn eine neue Prozess gestatet wird
        /// </summary>
        public event LoggerBeginProgressDelegate LoggerBeginProgress;

        /// <summary>
        /// Löst aus wenn ein Prozess aktualisiert wird
        /// </summary>
        public event LoggerUpdateProgressDelegate LoggerUpdateProgress;

        /// <summary>
        /// Löst aus wenn ein Prozess beendet wird
        /// </summary>
        public event LoggerEndProgressDelegate LoggerEndProgress;

        /// <summary>
        /// Löst aus wenn ein Status gestartet wird
        /// </summary>
        public event LoggerBeginStateDelegate LoggerBeginState;

        /// <summary>
        /// Löst aus wenn ein Status beendet wird
        /// </summary>
        public event LoggerEndStateDelegate LoggerEndState;

#pragma warning disable 1591

        protected override void OnLogMessage(LoggerMessageType type, string message)
        {
            if (LoggerMessage != null) LoggerMessage.Invoke(type, message);
        }

        protected override void OnLogException(Exception ex, string membername, int linenumber, string file)
        {
            if (LoggerException != null) LoggerException.Invoke(ex, membername, linenumber, file);
        }

        protected override void OnBeginProgress(float count, string message)
        {
            if (LoggerBeginProgress != null) LoggerBeginProgress.Invoke(count, message);
        }

        protected override void OnUpdateProgress(float count, string message, float percent)
        {
            if (LoggerUpdateProgress != null) LoggerUpdateProgress.Invoke(percent);
        }

        protected override void OnEndProgress(float count, string message, bool abort)
        {
            if (LoggerEndProgress != null) LoggerEndProgress.Invoke(abort);
        }

        protected override void OnBeginState(string message)
        {
            if (LoggerBeginState != null) LoggerBeginState.Invoke(message);
        }

        protected override void OnEndState(LoggerStateResult result)
        {
            if (LoggerEndState != null) LoggerEndState.Invoke(result);
        }
    }
}
