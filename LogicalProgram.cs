using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramUC4
{
    public  class LogicalProgram
    {
        public static void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter A Number");
            n= int.Parse(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n/=10;
            }
            Console.WriteLine("Reversed Number:" + reverse);
        }
    }
}
