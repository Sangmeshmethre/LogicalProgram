using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramUC3
{
    public  class LogicalProgram
    {
        public static void PrimeNumber()
        {
            int n,i,m=0, flag=0;
            Console.WriteLine("Enter The Number To Check Prime :");
            n=int.Parse(Console.ReadLine());
            m = n / 2;
            for (i=2; i<=m; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine("Number Is Not Prime.");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
            {
                Console.WriteLine("Number Is Prime.");
            }
        }
    }
}
