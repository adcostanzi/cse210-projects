using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int answer2 = 0;
        EventHandler handler = new EventHandler();
        do
        {
            Console.WriteLine("What type of event would you like to create?");
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Reception");
            Console.WriteLine("3. Outdoor Gathering");
            Console.Write("Your choice: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Lecture newLecture = new Lecture();
                handler.AddEvent(newLecture);
            }
            else if (answer == 2)
            {
                Reception newReception = new Reception();
                handler.AddEvent(newReception);
            }
            else if (answer == 3)
            {
                OutdoorGathering newOutdoorGathering = new OutdoorGathering();
                handler.AddEvent(newOutdoorGathering);
            }
            Console.Write("\nWould you like to create another event (1: yes / 2: no)? ");
            answer2 = int.Parse(Console.ReadLine());
        } while (answer2 != 2);
        
        handler.DisplayEvents();

        Console.WriteLine("\nThank you for using our service!");
    }
}