using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_Task_Continuation13
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() =>
              {
                  Console.WriteLine("Id of task {0}", Task.CurrentId);
              });
            Task task2 = task1.ContinueWith(Display);
            task1.Start();
            task2.Wait();
            Console.WriteLine("Method main is running");



            Console.ReadLine();
        }
        static void Display(Task t)
        {
            Console.WriteLine("Id of task {0}", Task.CurrentId);
            Console.WriteLine("Id of previous task {0}", t.Id);
            Thread.Sleep(3000);
        }
    }
}
