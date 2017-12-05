using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

/*
 * Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop.
 * We call the start method ﬁrst, and the stop method next. Then we ask the stopwatch about the duration between start and stop.
 * Duration should be a value in TimeSpan. Display the duration on the console. 
 */
namespace Section2_Exercise1_StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
           
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();

            //Get the elapsed time as a TimeSpan value.
            TimeSpan timspan = stopwatch.Elapsed;

            
            
            //Format and display the TimeSpan value
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", timspan.Hours, timspan.Minutes, timspan.Seconds);
            Console.WriteLine("Duration: " + elapsedTime);
                                                                        
        }

    }
}
/*1 method
 *Stopwatch stopwatch = new Stopwatch();
           
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();

            //Get the elapsed time as a TimeSpan value.
            TimeSpan timspan = stopwatch.Elapsed;

            
            
            //Format and display the TimeSpan value
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", timspan.Hours, timspan.Minutes, timspan.Seconds);
            Console.WriteLine("Duration: " + elapsedTime);
 * /
/*2nd method
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

/*
 * Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop.
 * We call the start method ﬁrst, and the stop method next. Then we ask the stopwatch about the duration between start and stop.
 * Duration should be a value in TimeSpan. Display the duration on the console. 
 /*
namespace Section2_Exercise1_StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(1000);
                stopwatch.Stop();

                //Get the elapsed time as a TimeSpan value.
                TimeSpan timspan = stopwatch.Elapsed;

                //Format and display the TimeSpan value
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", timspan.Hours, timspan.Minutes, timspan.Seconds);
                Console.WriteLine("Duration: " + elapsedTime);
            }

            Console.WriteLine("Press Enter to run the stopwatch one more time.");
            Console.WriteLine();
        }

    }
}
*/
