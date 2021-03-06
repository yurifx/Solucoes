﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Template
{
    class WindowsEventLogger : DataLogger
    {
        const string LOG_SOURCE = "TemplatePattern";

        public override void LogData(string data)
        {
            if (!EventLog.SourceExists(LOG_SOURCE))
            {
                EventLog.CreateEventSource(LOG_SOURCE, "Application");
            }

            string message = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + ": " + data;
            EventLog.WriteEntry(LOG_SOURCE, message, EventLogEntryType.Information);
        }
    }
}
