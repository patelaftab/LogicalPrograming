using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Checkingperfectnumber()
        {
            Console.WriteLine("Enter A Number To Check Perfect or Not");
            int Number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum = sum + 1;
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("The Sum of Divisors {0}");
            if (sum == Number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Given Number is Perfect Number");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Given Number IS Not a Perfect NUmber");
            }
        }

    }
}
