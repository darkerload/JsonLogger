using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLogger.Core
{
    public class LoggerSettings
    {
        public LoggerSettings()
        {

        }

        public bool IsAllowForWrite(LogModel logModel)
        {
            var getSettings = LoadSettings().FirstOrDefault(c => c.name == logModel.LogName);
            if (getSettings != null && getSettings.allow != "*")
            {
                string logModelAllow = logModel.NotifyType.ToString();
                return getSettings.allow.Contains(logModelAllow);
            }
            return true;
        }

        public List<Log> LoadSettings()
        {
            string text = File.ReadAllText(@"Settings.json");
            var rootObject = JsonConvert.DeserializeObject<RootObject>(text);
            return rootObject.settings.log;
        }


    }
}
