using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programing Programs\n" +
                "Choose a given Option \n" +
                "1: Fibonacci Series Program\n" +
                "2: Prime Number program\n" +
                "3: Reverse Number Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;
                case 2:
                    PrimeNnumbers primeNnumbers = new PrimeNnumbers();
                    primeNnumbers.Checkprimenumbers();
                    break;
                case 3:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.Chekingreversenumber();
                    break;
                default:
                    Console.WriteLine("Choose a Correct Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
