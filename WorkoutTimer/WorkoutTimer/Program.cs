namespace WorkoutTimer
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int setLength = 0;
            int setNumber = 0;

            string setLengthString = string.Empty;
            string setNumberString = string.Empty;

            bool setLengthGiven = false;
            bool setNumberGiven = false;

            if (args.Length == 2)
            {
                setLengthString = args[0];
                setNumberString = args[1];
                setLengthGiven = true;
                setNumberGiven = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("This is an interval timer");
                Console.WriteLine("You will enter the length of the sets in seconds, and the number of sets desired.");
                Console.WriteLine("Use the numeric keys to enter your answers.");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
            }

            // Take in length of sets, verify entry.
            do
            {
                if (!int.TryParse(setLengthString, out setLength))
                {
                    if (setLengthGiven)
                    {
                        Console.WriteLine("Invalid entry, type in the length of sets desired using the numberic key. (in seconds)");
                        Console.WriteLine();
                    }

                    Console.WriteLine("How long would you like the sets to be? (in seconds)");
                    setLengthString = Console.ReadLine();
                    setLengthGiven = true;
                    Console.WriteLine();
                }
            }
            while (setLength == 0);

            // Take in number of sets, verify entry.
            do
            {
                if (!int.TryParse(setNumberString, out setNumber))
                {
                    if (setNumberGiven)
                    {
                        Console.WriteLine("Invalid entry, input number of sets desired using the numeric keys");
                        Console.WriteLine();
                    }

                    Console.WriteLine("How many sets would you like?");
                    setNumberString = Console.ReadLine();
                    setNumberGiven = true;
                    Console.WriteLine();
                }
            }
            while (setNumber == 0);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"The program will now run {setNumber} sets of {setLength} second intervals");
            Console.WriteLine();
            Console.WriteLine("You will be notified with a Beep after each set.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();

            SetTimer.Start(setLength, setNumber);

            Console.WriteLine();
            Console.WriteLine("Sets completed! Nice work.");
            Console.WriteLine();

            Console.Write("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}