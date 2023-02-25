using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfulness Tracker!\n");
        ListingActivity listingActivity = new ListingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        BreathingActivity breathingActivity = new BreathingActivity();
        int userOption = 0;

        while (userOption != 4)
        {
            Console.WriteLine("Please choose from the following menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            
            do
            {
                Console.Write("\nChoose your option: ");
                userOption = int.Parse(Console.ReadLine());
                if (userOption >= 1 && userOption <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid option please try again. \n");
                }
            } while (userOption < 1 && userOption > 4);

        if (userOption == 1)
        {
           
            breathingActivity.LoadActivity();
            breathingActivity.PerformBreathingActivity();
            breathingActivity.DisplayEndingMessage();
        }
        else if (userOption == 2)
        {
            
            reflectionActivity.LoadActivity();
            reflectionActivity.PerformReflectionActivity();
            reflectionActivity.DisplayEndingMessage();
        }
         else if (userOption == 3)
        {
            
            listingActivity.LoadActivity();
            listingActivity.PerformListingActivity();
            listingActivity.DisplayEndingMessage();
        }
            
        }
    }
}