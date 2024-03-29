﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_07AutoResetEvent
{
    class Program
    {
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
        static int x = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Thread " + i.ToString();
                myThread.Start();
            }



            Console.ReadLine();
        }
        static void Count()
        {
            waitHandler.WaitOne();
            x = 1;
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("{0} {1}", Thread.CurrentThread.Name, x);
                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
    }
}
