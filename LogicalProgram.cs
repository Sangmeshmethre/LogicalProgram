using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramUC2
{
    public  class LogicalProgram
    {
        public static void PerfectNumber()
        {
            int number, sum = 0, n;
            Console.Write("Enter The  Number ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Enter The Number Is Perfect Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Enter The Number Is Not A Perfect Number");
                Console.ReadLine();
            }
        }
    }
}
