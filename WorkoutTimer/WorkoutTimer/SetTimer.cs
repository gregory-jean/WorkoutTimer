namespace WorkoutTimer
{
    using System;
    using System.Threading;

    public class SetTimer
    {
        public static void Start(int length, int repeatTimes)
        {
            for (var i = 0; i < repeatTimes; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(length));

                Console.Beep();
                Console.WriteLine((i + 1) + " of " + repeatTimes + " sets completed.");
            }
        }

    }
}

