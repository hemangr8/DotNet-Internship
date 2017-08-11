using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class ClassForLogging : EventLog
{
    public static void LogCustomException(string ErrorDetail)
    {
        string Log = "CustomException";

        if (!(EventLog.SourceExists(Log)))
        {
            EventLog.CreateEventSource(Log, Log);
        }

        EventLog LogEntry = new EventLog();
        LogEntry.Source = Log;
        EventLog.WriteEntry(Log, ErrorDetail);
    }
}