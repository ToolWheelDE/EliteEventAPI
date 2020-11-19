namespace EliteEventAPI.Diagnostics.Logging
{
    /// <summary>
    /// Ermöglicht das Logginziel zu Konfigurieren
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LoggerTargetConfiguration<T> where T : LoggerTarget
    {
        internal LoggerTargetConfiguration(T target)
        {
            Target = target;
        }

        /// <summary>
        /// Legt fest ob das Loggingziel aktiv ist
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public LoggerTargetConfiguration<T> SetEnabled(bool value)
        {
            Target.IsEnabled = value;
            return this;
        }

        /// <summary>
        /// Liegt den min. Nachrichtetype fest
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public LoggerTargetConfiguration<T> SetMinLevel(LoggerMessageType level)
        {
            Target.MinLevel = level;
            return this;
        }

        /// <summary>
        /// Liegt den max. Nachrichtetype fest
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public LoggerTargetConfiguration<T> SetMaxLevel(LoggerMessageType level)
        {
            Target.MaxLevel = level;
            return this;
        }

        /// <summary>
        /// Liefert das Loggingziel
        /// </summary>
        protected T Target { get; private set; }
    }
}
