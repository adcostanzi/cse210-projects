using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int yourGuess;
        string toGuess = " ";
        bool done = false;
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1,100);
        do
        {
            Console.WriteLine("What is your guess?");
            toGuess = Console.ReadLine();
            yourGuess = int.Parse(toGuess);

            if (magicNumber == yourGuess)
            {
                Console.WriteLine("You guessed! Congratulations!");
                done = true;
            } else if (magicNumber > yourGuess){
                Console.WriteLine("Higher");
            } else 
            {
                Console.WriteLine("Lower");
            }
        } while (done == false);
        
    }
}