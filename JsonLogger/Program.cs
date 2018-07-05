using System;
using System.Threading;
using JsonLogger.Core;
using System.Threading.Tasks;

namespace JsonLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new Logger("connection");

            log.Write("test", NotifyType.Error);

            Parallel.For(0, 20, i =>
            {
                log.Write("test : " + i.ToString(), NotifyType.Warning);
            });

            Console.WriteLine("-- Done --");
            Console.Read();

        }
    }
}
