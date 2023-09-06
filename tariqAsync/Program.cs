using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tariqAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodOne().GetAwaiter().GetResult();
            MethodTwo().GetAwaiter().GetResult();
            Console.ReadLine();
        }
        private static async Task MethodOne()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("This is Process one Stated....");
                Thread.Sleep(10000);
                Console.WriteLine("Process one Completed");
            });
        }
        private static async Task MethodTwo()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("This is Process two Stated....");
                Thread.Sleep(5000);
                Console.WriteLine("Process two Completed");
            });

        }

       
    }
}
