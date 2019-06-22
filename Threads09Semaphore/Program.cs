using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads09Semaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Reader reader = new Reader(i);
            }

            Console.ReadLine();
        }
    }
    class Reader
    {
        static Semaphore sem = new Semaphore(3,3);
        Thread myThread;
        int count = 3;//reader counter
        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = "Reader " + i.ToString();
            myThread.Start();
        }
        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();
                Console.WriteLine("{0} entered to Library", Thread.CurrentThread.Name);
                Console.WriteLine("Is reading {0}", Thread.CurrentThread.Name);
                Thread.Sleep(1000);
                Console.WriteLine("Leave library {0}", Thread.CurrentThread.Name);

                sem.Release();
                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
