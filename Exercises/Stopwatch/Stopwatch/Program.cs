using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice. 
*/


namespace StopwatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Press 'Enter' to start or type 'exit' to exit from the program");
            var Start = Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            if (string.IsNullOrWhiteSpace(Start))
            {
                stopwatch.Start();
            }

            else if (Start == "exit")
            {
                Console.WriteLine("Exit from the program");
                return;
            }
            

            Console.WriteLine("Press 'Spacebar' to stop");
            while (true)
            {
                var End = Console.ReadKey();

                if (End.Key == ConsoleKey.Spacebar)
                {
                    stopwatch.Stop();
                    Console.WriteLine("Elapsed Time : " + stopwatch.Duration());
                    return;
                }

                else if(End.Key == ConsoleKey.Enter)
                { 
                    throw new InvalidOperationException("Stopwatch already started");
                }
             continue;
             
            }    

        }

    }

}


