using System;

namespace EliteEventAPI.Diagnostics.Logging
{
    /// <summary>
    /// Eine Basisklasse die ein Loggerziel darstellt
    /// </summary>
    public abstract class LoggerTarget
    {
        internal void InternalLogMessage(LoggerMessageType type, string message)
        {
            if (!IsEnabled) return;

            if (type >= MinLevel & type <= MaxLevel)
            {
                OnLogMessage(type, message);
            }
        }

        internal void InternalLogException(Exception ex, string membername, int linenumber, string file)
        {
            if (!IsEnabled) return;

            OnLogException(ex, membername, linenumber, file);
        }

        internal void InternalBeginProgress(float count, string message)
        {
            if (!IsEnabled) return;

            OnBeginProgress(count, message);
        }

        internal void InternalUpdateProgress(float count, string message, float percent)
        {
            OnUpdateProgress(count, message, percent);
        }

        internal void InternalEndProgress(float count, string message, bool abort)
        {
            OnEndProgress(count, message, abort);
        }

        internal void InternalBeginState(string message)
        {
            if (!IsEnabled) return;

            OnBeginState(message);
        }

        internal void InternalEndState(LoggerStateResult type)
        {
            if (!IsEnabled) return;

            OnEndState(type);
        }

        /// <summary>
        /// Wird aufgerufen wenn eine Systemnachricht verarbeitet werden soll
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        protected abstract void OnLogMessage(LoggerMessageType type, string message);

        /// <summary>
        /// Wird aufgerufen wenn eine Ausnahme verarbeitet werden soll
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="membername"></param>
        /// <param name="linenumber"></param>
        /// <param name="file"></param>
        protected abstract void OnLogException(Exception ex, string membername, int linenumber, string file);

        /// <summary>
        /// Wird aufgerufen wenn ein Prozess beginnt
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        protected abstract void OnBeginProgress(float count, string message);

        /// <summary>
        /// Wird aufgerufen wenn sich ein Prozess aktualisiert
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <param name="percent"></param>
        protected abstract void OnUpdateProgress(float count, string message, float percent);

        /// <summary>
        /// Wird aufgerufen wenn ein Prozess endet
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <param name="abort"></param>
        protected abstract void OnEndProgress(float count, string message, bool abort);

        /// <summary>
        /// Wird aufgerufen wenn ein Status beginnt
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        protected abstract void OnBeginState(string message);

        /// <summary>
        /// Wird aufgerufen wenn ein Status endet
        /// </summary>
        /// <param name="type"></param>
        protected abstract void OnEndState(LoggerStateResult type);

        /// <summary>
        /// Gibt an das der Logger aktiv ist oder legt es fest
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Liefert die mindest Stufe der Nachricht oder legt sie fest
        /// </summary>
        public LoggerMessageType MinLevel { get; set; }

        /// <summary>
        /// Liefert die höhst Stufe der Nachricht oder legt sie fest
        /// </summary>
        public LoggerMessageType MaxLevel { get; set; }
    }
}
