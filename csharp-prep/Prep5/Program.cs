using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquareNumber = SquareNumber(userNumber);
        DisplayResult(userName, userSquareNumber);
    }

    static void DisplayWelcome()
       {
            Console.WriteLine("Welcome to the program!");
       }
        static string PromptUserName()
       {
            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            return name;
       }
       static int PromptUserNumber()
       {
            int number;
            string input;
            Console.WriteLine("Please enter you favourite number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            return number;
       }
       static int SquareNumber(int number)
       {
            int squareNumber = number*number;
            return squareNumber;
       }
       static void DisplayResult(string name, int number)
       {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
}