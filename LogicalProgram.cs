using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramUC6
{
    public class LogicalProgram
    {
        public static void SimulateStopWatch()
        {
            // Create New StopWatch
            Stopwatch stopwatch = new Stopwatch();
            //Begin Timing 
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }
            // Stop Timing 
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed:{0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
