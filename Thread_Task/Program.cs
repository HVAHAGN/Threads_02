using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(() => Console.WriteLine("Hello Task!"));
            task.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Helloll"));

            Task task3 = Task.Run(() => Console.WriteLine("Hello with Run"));
            Task task4 = new Task(Display);
            task4.Start();
            task4.Wait();
            Console.WriteLine("End of method Main");


            Console.ReadLine();
        }
        public static void Display()
        {
            Console.WriteLine("Starting method Display");
            Console.WriteLine("End of method Display");
        }
    }
}
