namespace EliteEventAPI.Diagnostics.Logging
{
    /// <summary>
    /// Nachrichtentypen
    /// </summary>
    public enum LoggerMessageType : int
    {
        /// <summary>
        /// Detailierte Ausgabe
        /// </summary>
        Trace = 0,

        /// <summary>
        /// Diaknostig aAugabe
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Information
        /// </summary>
        Normal = 2,

        /// <summary>
        /// Warnung
        /// </summary>
        Warning = 3,

        /// <summary>
        /// Fehler
        /// </summary>
        Error = 4
    }
}
