using System;

#pragma warning disable 1591

namespace EliteEventAPI.Diagnostics.Logging.Targets
{
    public class ConsoleLoggerTarget : LoggerTarget
    {
        public ConsoleLoggerTarget()
        {
            TraceColor = ConsoleColor.DarkGray;
            DebugColor = ConsoleColor.Blue;
            NormalColor = ConsoleColor.White;
            WarningColor = ConsoleColor.Yellow;
            ErrorColor = ConsoleColor.Red;
            ExceptionColor = ConsoleColor.Magenta;

            Configuration = new ConsoleLoggerTargetConfiguration(this);
        }

        protected override void OnBeginProgress(float count, string message)
        {
            // Nix machen
        }

        protected override void OnBeginState(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{message,-70}");
        }

        protected override void OnEndProgress(float count, string message, bool abort)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{message,-40} [{new string('=', 20),-20}] {100F:000.0}% ");

            if (abort)
            {
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("] ");
            }
            else
            {
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("OK");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("]");
            }
        }

        protected override void OnEndState(LoggerStateResult type)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[");
            switch (type)
            {
                case LoggerStateResult.Abort:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case LoggerStateResult.Yes:
                case LoggerStateResult.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case LoggerStateResult.No:
                case LoggerStateResult.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case LoggerStateResult.Done:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case LoggerStateResult.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.Write(type.ToString().ToUpper());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("]");
        }

        protected override void OnLogException(Exception ex, string membername, int linenumber, string file)
        {
            Console.ForegroundColor = ExceptionColor;

            Console.WriteLine($"EXCEPTION : {ex.GetType().Name}");
            Console.WriteLine($"{membername} :  {ex.Message}");
            Console.WriteLine($"{linenumber,-4} : {file}");
        }

        protected override void OnLogMessage(LoggerMessageType type, string message)
        {
            switch (type)
            {
                case LoggerMessageType.Trace: Console.ForegroundColor = TraceColor; break;
                case LoggerMessageType.Debug: Console.ForegroundColor = DebugColor; break;
                case LoggerMessageType.Normal: Console.ForegroundColor = NormalColor; break;
                case LoggerMessageType.Warning: Console.ForegroundColor = WarningColor; break;
                case LoggerMessageType.Error: Console.ForegroundColor = ErrorColor; break;
            }

            Console.WriteLine(message);
        }

        protected override void OnUpdateProgress(float count, string message, float percent)
        {
            var chars = new string('=', (int)(20F * percent));

            if (message.Length > 40) message = $"{message.Substring(0, 37)}...";

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{message,-40} [{chars,-20}] {percent * 100F:000.0}%\r");
        }

        public ConsoleColor DebugColor { get; set; }

        public ConsoleColor ErrorColor { get; set; }

        public ConsoleColor ExceptionColor { get; set; }

        public ConsoleColor NormalColor { get; set; }

        public ConsoleColor TraceColor { get; set; }

        public ConsoleColor WarningColor { get; set; }

        public ConsoleLoggerTargetConfiguration Configuration { get; private set; }
    }
}
