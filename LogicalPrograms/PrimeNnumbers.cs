using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNnumbers
    {
        public void Checkprimenumbers()
        {
            Console.WriteLine("\nWelcome To Prime Number Program");
            Console.WriteLine("enter the number to check for prime Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int value = number / 2;
            int temp = 0;
            for (int i = 2; i <= value; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("Above Number is  Not a Prime Number :" +number);
                    temp++;
                    break;
                }
            }
            if (temp == 0)
                Console.Write("Above Number is a Prime Number :" +number);
        }
    }
}
