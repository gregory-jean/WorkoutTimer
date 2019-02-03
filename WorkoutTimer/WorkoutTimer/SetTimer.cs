namespace WorkoutTimer
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class SetTimer
    {
        public static void Start(int length, int repeatTimes)
        {
            int count;
            for (var i = 0; i < repeatTimes; i++)
            {
                Console.WriteLine($"Starting set {i + 1}");
                count = 0;
                Stopwatch stopwatch = Stopwatch.StartNew();
                while(stopwatch.Elapsed.TotalSeconds < length)
                {
                    // Print a "." to the screen every second
                    if(stopwatch.Elapsed.TotalMilliseconds / 1000 > count)
                    {
                        Console.Write(".");
                        count++;
                    }
                }
                Console.WriteLine();

                Console.Beep();
                Console.WriteLine((i + 1) + " of " + repeatTimes + " sets completed.");
            }
        }
    }
}

