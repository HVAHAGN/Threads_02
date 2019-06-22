using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Threads_Async_Read_Write_15
{
    class Program
    {
        static async void ReadWriteAsync()
        {
            string s = "Hello world! How are you? My dear Vahagn, are you going to married?";
            using(StreamWriter writer=new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s);
            }
            using(StreamReader reader =new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            ReadWriteAsync();
            Console.WriteLine("NNNNN");


            Console.ReadLine();
        }
    }
}
