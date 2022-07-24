using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class mange_threads
    {
        private static string id;
        private static string choice;
        public static void mange()
        {
            while (true)
            {
                Console.WriteLine("1-stop Thread\n2-start Thread\n3-exit program");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                       stop();
                        break;
                    case "2":
                        start();
                        break;

                    case "3":
                        return;
                    default:
                        Console.Write("wrong choice\n");
                        break;
                }
            }
        }
        private static void stop()
        {
            Console.Write("Enter thread ID: ");
            id = Console.ReadLine();
            logfile.semaphores[int.Parse(id) - 1].WaitOne();
            Console.WriteLine($"Thread {id} stoped");
        }
        private static void start()
        {
            Console.Write("Enter thread ID: ");
            id = Console.ReadLine();
            logfile.semaphores[int.Parse(id) - 1].Release();
            Console.WriteLine($"Thread {id} started");

        }
    }
}
