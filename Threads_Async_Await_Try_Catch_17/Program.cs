using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_Async_Await_Try_Catch_17
{
    class Program
    {
        static void Factorial(int n)
        {
            if (n < 1)
                throw new Exception($"{n} must be greater than 1");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial of {n} is equal {result}");
        }
        static async void FactorialAsync(int n)
        {
            try
            {
                await Task.Run(() => Factorial(n));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Thread.Sleep(5000);
            FactorialAsync(15);


            Console.ReadLine();
        }
    }
}
