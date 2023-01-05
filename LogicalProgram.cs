using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramUC1
{
    public  class LogicalProgram
    {
        public static void FibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter The Number Of Elements");
            number = int.Parse(Console.ReadLine());

            //Priting 0 And 1
            Console.Write(n1 + "" + n2 + "");

            //Loop Start From 2 Becouse 0 & 1 Are Already Printed 
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3+"");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
