using System;



class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        int answer = 0;
        string filename;
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
                Console.WriteLine("Entry added to Journal!");
            }
            else if (answer == 2)
            {
                if (journal._content.Count == 0)
                {
                    Console.WriteLine("No entries to display.");
                }
                else
                {
                    Console.WriteLine("Your Journal:");
                    journal.DisplayJournal();
                }
               
            }
            else if (answer == 3)
            {
                Console.Write("Please write the name of the file you want to load (do not write extension): ");
                filename = Console.ReadLine()+".csv";
                if (!File.Exists(filename))
                {
                    Console.WriteLine("File was not found.");
                } 
                else if (filename=="prompts.csv")
                {
                    Console.WriteLine("That file is not available for loading.");
                }
                else
                {
                    journal.LoadJournal(filename, journal._content);
                    Console.WriteLine("Journal Loaded Sucessfully!");
                }
                
            }
            else if (answer == 4)
            {
                do
                {
                    Console.Write("Please write a name for the new file (do not write extension): ");
                    filename = Console.ReadLine()+".csv";
                    if (filename == "prompts.csv")
                    {
                        Console.WriteLine("That name cannot be used, please try again with another name.");
                    }
                } while (filename == "prompts.csv");
                
                journal.SaveJournal(filename, journal._content);
                Console.WriteLine("Journal Saved Sucessfully!");
            }
            
        }
        
        Console.WriteLine("Remember to come back tomorrow!");
    }
}