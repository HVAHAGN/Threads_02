using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var outer = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Outer task starting");
                var inner = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Innter task starting");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished");
                });

        });
            outer.Wait();
            Console.WriteLine("End of Main");

            Task[] task5 = new Task[3]
            {
                new Task(()=> Console.WriteLine("Task first")),
                new Task(()=> Console.WriteLine("Task second")),
                new Task(()=> Console.WriteLine("Task third")),
            };
            foreach (var item in task5)
            {
                item.Start();
            }
            

            Console.ReadLine();
        }
    }
}
