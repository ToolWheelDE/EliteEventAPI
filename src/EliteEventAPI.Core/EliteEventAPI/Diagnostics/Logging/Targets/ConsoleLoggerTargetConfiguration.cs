using System;

#pragma warning disable 1591

namespace EliteEventAPI.Diagnostics.Logging.Targets
{
    public sealed class ConsoleLoggerTargetConfiguration : LoggerTargetConfiguration<ConsoleLoggerTarget>
    {
        internal ConsoleLoggerTargetConfiguration(ConsoleLoggerTarget target)
            : base(target)
        { }

        public ConsoleLoggerTargetConfiguration SetColorTrace(ConsoleColor color)
        {
            Target.TraceColor = color;
            return this;
        }

        public ConsoleLoggerTargetConfiguration SetColorDebug(ConsoleColor color)
        {
            Target.DebugColor = color;
            return this;
        }

        public ConsoleLoggerTargetConfiguration SetColorNormal(ConsoleColor color)
        {
            Target.NormalColor = color;
            return this;
        }

        public ConsoleLoggerTargetConfiguration SetColorWarning(ConsoleColor color)
        {
            Target.WarningColor = color;
            return this;
        }

        public ConsoleLoggerTargetConfiguration SetColorError(ConsoleColor color)
        {
            Target.ErrorColor = color;
            return this;
        }

        public ConsoleLoggerTargetConfiguration SetColorException(ConsoleColor color)
        {
            Target.ExceptionColor = color;
            return this;
        }
    }
}
