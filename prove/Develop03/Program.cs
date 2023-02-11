using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Welcome to Scripture Memorizer v1.0:");

        Console.WriteLine("Please choose a scripture from the list to study: ");

        Database data = new Database();

        data.LoadData();

        string userOption; 

        data.DisplayData();

        bool testResponse;
        
        do
        {
        Console.Write("What scripture would you like to study? ");
        userOption = Console.ReadLine();
        testResponse = data.IsOptionViable(userOption);
        if (testResponse == false)
        {
            Console.WriteLine("\nInvalid option. Please Try again.\n");
        }
        } while (testResponse!=true);

        Scripture newScripture = data.GetScripture(userOption);      
    
        string answer;

        bool isScriptureComplete = false;

        Console.Clear();

        do
        {

            isScriptureComplete = newScripture.IsScriptureHidden();

            if (isScriptureComplete == true)
            {
                newScripture.DisplayScripture();
                Console.WriteLine("Scripture completed! Press any key to finish");
                Console.ReadLine();
                break;
            }


            newScripture.DisplayScripture();

            do
            {
                Console.Write("Press Enter to continue studying or write quit to exit: ");
                answer = Console.ReadLine();
                if (answer != "quit" && answer != "")
                {
                    Console.WriteLine("\nInvalid input. Please try again.\n");
                }
            } while (answer != "quit" && answer != "");
            
            newScripture.HideWords();
            Console.Clear();
            

        } while (answer != "quit");

       
    
    }
}