using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_Async_Await_16
{
    class Program
    {
        static void Factorial (int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;

            }
            Thread.Sleep(5000);
            Console.WriteLine($"Facotorial of {n} is equal to {result}");
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() =>Factorial(n));
            
        }
        static void Main(string[] args)
        {
            FactorialAsync(5);
            FactorialAsync(6);
            FactorialAsync(7);
            Console.WriteLine("Something ");
            Console.ReadLine();
        }
    }
}
