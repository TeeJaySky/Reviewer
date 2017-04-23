using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reviewer
{
    class OutputWriter
    {
        static ConcurrentQueue<string> messagesToWrite = new ConcurrentQueue<string>();
        static ManualResetEvent stopWriter = new ManualResetEvent(false);

        public static void ThreadMain()
        {
            while(true)
            {


                stopWriter.WaitOne(500);
            }
        }

        public static void WriteToFile()
        {

        }

        public static void Stop()
        {
            stopWriter.Set();
        }
    }
}
