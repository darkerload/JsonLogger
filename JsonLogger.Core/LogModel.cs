using System;
namespace JsonLogger.Core
{
    public class LogModel
    {
        public Guid Guid { get; set; }
        public string LogName { get; set; }
        public string Message { get; set; }
        public NotifyType NotifyType { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
