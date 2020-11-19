using System;
using System.Collections.Generic;

namespace EliteEventAPI.Diagnostics.Logging
{
    /// <summary>
    /// Stellt ein Loggersystem bereit
    /// </summary>
    public class LoggerManager
    {
        private static readonly Dictionary<string, LoggerTarget> _targets = new Dictionary<string, LoggerTarget>(StringComparer.InvariantCultureIgnoreCase);

        private static Tuple<string, float> _progressbar;
        private static Tuple<string> _state;

        /// <summary>
        /// Fügt ein Loggingziel dem Logger hinzu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static T Add<T>(string name, T target) where T : LoggerTarget
        {
            target.IsEnabled = IsEnabled;
            target.MinLevel = MinLevel;
            target.MaxLevel = MaxLevel;

            _targets[name] = target;

            return target;
        }

        /// <summary>
        /// Liefert ein Loggingziel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T GetLogger<T>(string name) where T : LoggerTarget
        {
            return (T)_targets[name];
        }

        /// <summary>
        /// Entfernt ein Loggingziel
        /// </summary>
        /// <param name="name"></param>
        public static void Remove(string name)
        {
            _targets.Remove(name);
        }

        /// <summary>
        /// Loggt eine Systemnachricht
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogMessage(LoggerMessageType type, string message)
        {
            lock (_targets)
            {
                if (_state != null) EndState(LoggerStateResult.Abort);
                if (_progressbar != null) EndProgress(true);

                if (!IsEnabled) return;

                if (type >= MinLevel & type <= MaxLevel)
                {

                    foreach (var target in _targets.Values)
                    {
                        target.InternalLogMessage(type, message);
                    }
                }
            }
        }

        /// <summary>
        /// Loggt eine Ausnahme
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="membername"></param>
        /// <param name="linenumber"></param>
        /// <param name="file"></param>
        public static void LogException(Exception ex, string membername = "", int linenumber = 0, string file = "")
        {
            lock (_targets)
            {
                if (_state != null) EndState(LoggerStateResult.Abort);
                if (_progressbar != null) EndProgress(true);

                if (!IsEnabled) return;


                foreach (var target in _targets.Values)
                {
                    target.InternalLogException(ex, membername, linenumber, file);
                }
            }
        }

        /// <summary>
        /// Startet einen Prozess
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        public static void BeginProgress(float count, string message)
        {
            lock (_targets)
            {
                if (_state != null) EndState(LoggerStateResult.Abort);
                if (_progressbar != null) EndProgress(true);

                if (!IsEnabled) return;

                _progressbar = new Tuple<string, float>(message, count);

                foreach (var target in _targets.Values)
                {
                    target.InternalBeginProgress(count, message);
                }
            }

            UpdateProgress(0);
        }

        /// <summary>
        /// Aktualisiert einen Prozess
        /// </summary>
        /// <param name="count"></param>
        public static void UpdateProgress(float count)
        {
            lock (_targets)
            {
                if (_progressbar == null) return;

                var percent = (count / _progressbar.Item2);

                foreach (var target in _targets.Values)
                {
                    target.InternalUpdateProgress(_progressbar.Item2, _progressbar.Item1, percent);
                }
            }
        }

        /// <summary>
        /// Beendet einen Prozess
        /// </summary>
        /// <param name="abort"></param>
        public static void EndProgress(bool abort)
        {
            lock (_targets)
            {
                if (_progressbar == null) return;

                foreach (var target in _targets.Values)
                {
                    target.InternalEndProgress(_progressbar.Item2, _progressbar.Item1, abort);
                }

                _progressbar = null;
            }
        }

        /// <summary>
        /// Beginnt einen Status
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void BeginState(string message)
        {
            lock (_targets)
            {
                if (!IsEnabled) return;

                foreach (var target in _targets.Values)
                {
                    target.InternalBeginState(message);
                }

                _state = new Tuple<string>(message);
            }
        }

        /// <summary>
        /// Beendet einen Status
        /// </summary>
        /// <param name="type"></param>
        public static void EndState(LoggerStateResult type)
        {
            lock (_targets)
            {
                if (_state == null) return;

                foreach (var target in _targets.Values)
                {
                    target.InternalEndState(type);
                }

                _state = null;
            }
        }

        /// <summary>
        /// Gibt an das der Logger aktiv ist oder legt es fest
        /// </summary>
        public static bool IsEnabled { get; set; }

        /// <summary>
        /// Liefert die mindest Stufe der Nachricht oder legt sie fest
        /// </summary>
        public static LoggerMessageType MinLevel { get; set; }

        /// <summary>
        /// Liefert die höhst Stufe der Nachricht oder legt sie fest
        /// </summary>
        public static LoggerMessageType MaxLevel { get; set; }
    }
}
