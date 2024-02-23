using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskScheduler
{
    internal class Job2
    {
        public void DoJob(int interval)
        {
            while (true)
            {
                Console.WriteLine("Job2 completed at: " + DateTime.Now);
                Thread.Sleep(interval);
            }
        }
    }
}
