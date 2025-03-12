using System.Diagnostics;

namespace WindowsEventLog
{
    internal enum LogLevel
    {
        Info = EventLogEntryType.Information,
        Warning = EventLogEntryType.Warning,
        Error = EventLogEntryType.Error
    }
}
