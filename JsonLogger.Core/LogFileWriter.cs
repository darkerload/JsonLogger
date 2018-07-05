using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Threading;

namespace JsonLogger.Core
{
    public class LogFileWriter
    {
        private static readonly Lazy<LogFileWriter> _instance = new Lazy<LogFileWriter>(() => new LogFileWriter(), true);
        static ReaderWriterLock readerWriterLock = new ReaderWriterLock();

        public void WriteToFile(LogModel logModel)
        {
            try
            {
                readerWriterLock.AcquireWriterLock(int.MaxValue);
                string json = JsonConvert.SerializeObject(logModel);
                File.AppendAllText("log.txt", json);
            }
            finally
            {
                readerWriterLock.ReleaseWriterLock();
            }

        }

        public static LogFileWriter Instance
        {
            get { return _instance.Value; }
        }
    }
}
