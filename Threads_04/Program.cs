using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(5, 4);
            Thread myThread = new Thread(new ThreadStart(counter.Count));
            myThread.Start();

            Console.ReadLine();
        }
    }
    public class Counter
    {
        private int _x;
        private int _y;
        public Counter(int x, int y)
        {
            this._x = x;
            this._y = y;

        }
        public void Count()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Second thread");
                Console.WriteLine(i*_x*_y);
                Thread.Sleep(400);
            }
        }

    }
}
