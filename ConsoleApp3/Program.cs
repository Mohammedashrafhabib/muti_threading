using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
namespace ConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter number of threads: ");
            string number;
            number = Console.ReadLine();
            Console.Write("Enter time of wait in seconds: ");
            logfile.time = int.Parse(Console.ReadLine()) * 1000;
            for (int i = 1; i <= int.Parse(number); i++)
            {
                logfile.semaphores.Add(new Semaphore(1, 1));
                ThreadPool.QueueUserWorkItem(logfile.Print_to_File, i);
            }
            mange_threads.mange();
        }
    }
}
