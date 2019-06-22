using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Thread t = Thread.CurrentThread;
            Console.WriteLine("Name of thread is {0}", t.Name);
            t.Name = "Main";
            Console.WriteLine("Name of thread is {0}", t.Name);
            Console.WriteLine("Thread is alive? {0}", t.IsAlive);
            Console.WriteLine("Priority of Thread is {0}", t.Priority);
            Console.WriteLine("Status of thread {0}", t.ThreadState);
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("The Main thread");
                Console.WriteLine(i*i);
                Thread.Sleep(300);
            }






            Console.ReadLine();
        }
        public static void Count()
        {
            for (int i = 0; i < 9; i++)
            {

                Console.WriteLine("The second thread");
                Console.WriteLine(i*i);
                Thread.Sleep(400);
            }
        }
    }
}
