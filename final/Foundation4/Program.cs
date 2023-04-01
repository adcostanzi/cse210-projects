using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int answer2 = 0;
        ActivityHandler handler = new ActivityHandler();

        do
        {
            Console.WriteLine("What type of activity are you performing?");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.Write("Your choice: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Running newRunningActivity = new Running();
                handler.AddActivity(newRunningActivity);
            }
            else if (answer == 2)
            {
                Cycling newCyclingActivity = new Cycling();
                handler.AddActivity(newCyclingActivity);
            }
            else if (answer == 3)
            {
                Swimming newSwimmingActivity = new Swimming();
                handler.AddActivity(newSwimmingActivity);
            }

            Console.Write("Would you like to add another activity (yes: 1 / no:2)? ");
            answer2 = int.Parse(Console.ReadLine());
        } while (answer2 != 2);
        handler.DisplayActivities();
    }
}