using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace ConsoleApp3
{
    static class logfile
    {
      public  static readonly List<Semaphore> semaphores = new List<Semaphore>();

        public static int time = 10000;
        public static void Print_to_File(object id)
        {
            StreamWriter file = new StreamWriter("thread " + (int)id + ".txt", false);
            while (true)
            {
                semaphores[(int)id - 1].WaitOne();

                file.WriteLine($"thread {(int)id}:"+DateTime.Now.ToString());

                ;

                file.Flush();
                semaphores[(int)id - 1].Release();
                Thread.Sleep(time);
            }

        }
    }
}
