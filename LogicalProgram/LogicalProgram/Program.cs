using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the logical problem");
            FibonacciSeries series = new FibonacciSeries();
            series.Fibo();
            Console.ReadLine();
        }
    }
}
