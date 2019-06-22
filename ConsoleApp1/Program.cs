using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_14AsyncAwait
  {
    class Program
    {
        static void Factorial()
        {
            int result = 1;
            for (int i = 1 ; i < 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Factorial equal to {result}");
            
        }
        static async void FactorialAsync()
        {
            Console.WriteLine("Started asyncfactorial");
            await Task.Run(() => Factorial());
            Console.WriteLine("End of asyncFactorial");

        }


        static void Main(string[] args)
        {
            FactorialAsync();
            Console.WriteLine("Please enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"you entered {n} square is equal to {n*n}");


            Console.ReadLine();
        }
    }
}
