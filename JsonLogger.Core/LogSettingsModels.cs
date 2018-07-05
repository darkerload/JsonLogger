using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLogger.Core
{
    public class Log
    {
        public string name { get; set; }
        public string allow { get; set; }
    }

    public class Settings
    {
        public List<Log> log { get; set; }
    }

    public class RootObject
    {
        public Settings settings { get; set; }
    }
}
