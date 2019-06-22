using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_10Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(Count);
            //create timer
            Timer timer = new Timer(tm, num, 0, 2000);
            Console.ReadLine();


            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            DateTime dt = DateTime.Now;
            
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine("{0}  ***  {1}", x*i, dt);
                Thread.Sleep(1000);
            }
        }
    }
}
