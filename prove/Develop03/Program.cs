using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference newReference = new Reference("John",3,16);

        Scripture newScripture = new Scripture (newReference,"For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
    
        string answer;

        bool isScriptureComplete = false;

        Console.WriteLine("Welcome to Scripture Memorizer v1.0:");
        
        do
        {

            isScriptureComplete = newScripture.IsScriptureHidden();

            if (isScriptureComplete == true)
            {
                newScripture.DisplayScripture();
                Console.WriteLine("Scripture completed!");
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