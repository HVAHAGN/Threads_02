using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(number);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("The Main thread");
                Console.WriteLine(i*i);
                Thread.Sleep(400);
            }


            Console.ReadLine();
        }

        public static void Count(object x)
        {
            for (int i = 0; i < 9; i++)
            {
                int n = (int)x; ;
                Console.WriteLine("Second thread");
                Console.WriteLine(i*n);
                Thread.Sleep(400);
            }
        }
    }
}
