using System;
using System.Timers;
using System.Threading;

namespace WorkoutTimer
{
    public class Timer
    {
        public static void Start(int length, int repeatTimes )
        {
            for (var i = 0; i < repeatTimes; i++)
            {
                System.Threading.Thread.Sleep(length * 1000);

                Console.Beep();
                Console.WriteLine((i+1) + " of " + repeatTimes + " sets completed.");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Take in length of set, reset 
            Console.WriteLine("How long would you like the timer to be?");
            int setLength = int.Parse(Console.ReadLine());
            // Take in number of sets
            Console.WriteLine("How many sets would you like?");
            int setNumber = int.Parse(Console.ReadLine());
            // Apply inputs into timer method

            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();

            Timer.Start(setLength, setNumber);





        }
    }
}
