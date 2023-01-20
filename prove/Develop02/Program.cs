using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        int answer = 0;
        Console.WriteLine("Welcome to your Journal!");
        while (answer != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load Journal from a file");
            Console.WriteLine("4. Save journal to a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Please choose from the options above: ");
            answer = int.Parse(Console.ReadLine());


            if (answer == 1)
            {
                journal._content.Add(journal.AddEntry());
            }
            else if (answer == 2)
            {
                journal.DisplayJournal();
            }
        }
        
        
        
        
        Console.WriteLine("Remember to come back tomorrow!");
    }
}