using System;
using System.Diagnostics;
using System.Security;

namespace WindowsEventLog
{
    internal class Logger : IDisposable
    {
        private const string LOGNAME = "ISET2025";
        private const string DEFAULT_WINDOWS_LOG = "Application";
        private readonly EventLog log;

        public Logger()
        {
            string logName = DefineLogName();

            log = new EventLog(logName)
            {
                Source = logName
            };
        }

        private string DefineLogName()
        {
            if (CreateSourceIfNotExist())
            {
                return LOGNAME;
            }
            return DEFAULT_WINDOWS_LOG;
        }

        public void Log(string message, LogLevel level = LogLevel.Info)
        {
            log.WriteEntry(message, (EventLogEntryType)level);
        }

        private bool CreateSourceIfNotExist()
        {
            try
            {
                if (!EventLog.SourceExists(LOGNAME)) //Exception will be thrown here if we don't have the admin rights
                {
                    CreateSource(); //Exception will be thrown here as well if we don't have the admin rights
                }
                return true;
            }
            catch (SecurityException)
            {
                //We don't have the rights (this needs to run as admin)
                return false;
            }
        }

        private static void CreateSource()
        {
            EventLog.CreateEventSource(LOGNAME, LOGNAME);
        }

        public void Dispose()
        {
            ((IDisposable)log).Dispose();
        }
    }
}
