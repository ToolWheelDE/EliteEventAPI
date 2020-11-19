namespace EliteEventAPI.Diagnostics.Logging
{
    /// <summary>
    /// Status Ergebnisse
    /// </summary>
    public enum LoggerStateResult
    {
        /// <summary>
        /// Abgebrochen
        /// </summary>
        Abort,

        /// <summary>
        /// Erfolgreich
        /// </summary>
        Success,

        /// <summary>
        /// Fertig
        /// </summary>
        Done,

        /// <summary>
        /// Error
        /// </summary>
        Error,

        /// <summary>
        /// Warning
        /// </summary>
        Warning,

        /// <summary>
        /// Ja
        /// </summary>
        Yes,

        /// <summary>
        /// Nein
        /// </summary>
        No
    }
}