using System;
using System.Threading;

namespace HelloBoy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! Now is {DateTime.Now}");
            Thread.Sleep(4000);
            Console.WriteLine($"Time is :{DateTime.Now}");
         //   Console.ReadKey();
        }
    }
}
