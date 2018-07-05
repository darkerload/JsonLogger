using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace JsonLogger.Core
{
    public class Logger
    {
        string logName = string.Empty;

        public Logger(string logName)
        {
            this.logName = logName;
        }

        public void Write(string message = "", NotifyType notifyType = NotifyType.Default)
        {
            var logModel = new LogModel()
            {
                LogName = logName,
                Message = message,
                Guid = Guid.NewGuid(),
                NotifyType = notifyType,
                CreateDate = DateTime.Now
            };

            var logSettings = new LoggerSettings();

            if (logSettings.IsAllowForWrite(logModel))
                LogFileWriter.Instance.WriteToFile(logModel);

        }

       

    }
}
