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
            /*FibonacciSeries series = new FibonacciSeries();
            series.Fibo();*/
            /* PerfectNumber perfectnum = new PerfectNumber();
             perfectnum.Perfect();*/
            /* PrimeNumber primenum = new PrimeNumber();
             primenum.Prime();*/
            /* Reversenumber reversenum = new Reversenumber();
             reversenum.Reverse();*/
            /*CouponNumbers couponNumbers = new CouponNumbers();
            couponNumbers.couponsNumbers();*/
           /* StopwatchProgram bhosale = new StopwatchProgram();
            bhosale.Elapsetime(); */
                Console.WriteLine("Enter Amount to get Change");
            /*int amount = Convert.ToInt32(Console.ReadLine());
            VendingMachine vending = new VendingMachine();
            vending.Getchange(amount);
            DayOffWeek weekday = new DayOffWeek();
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            weekday.Day(day, Month, year);
            TempratureConversion temperature = new TempratureConversion();
            Console.WriteLine("Enter value of temperature ");
            int temp = Convert.ToInt32(Console.ReadLine());
            temperature.temperatureconversion(temp);*/

            /* MonthlyPayment month = new MonthlyPayment();
             Console.WriteLine("Enter the value of principal");
             double p = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter the year");
             double y = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter the rate : ");
             double R = Convert.ToDouble(Console.ReadLine());
             month.monthlypayment(p, y, R);*/
            /* SquareRoot.Sqrt();*/
            /* BinaryConversion bin = new BinaryConversion();
             bin.decimalToBinary();*/
            SwapNibles obj12 = new SwapNibles();
            Console.WriteLine("Enter number to convert in Binary :");
            int number = Convert.ToInt32(Console.ReadLine());
            obj12.ToBinary(number);
            Console.ReadLine();


        }
    }
}
