using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";
        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string sign = " ";
        
        int remainder = gradePercentage % 10;
        if (gradePercentage >= 60 && gradePercentage < 90)
        {
            if (remainder <= 3) 
            {
                sign = "-";
            } else if (remainder >= 7) {
                sign = "+";
            }
        }

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        } else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        } else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        } else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        } else 
        {
            gradeLetter = "F";
        }
        Console.WriteLine($"Your grade is {gradeLetter}{sign}");

        if (gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C")
        {
            Console.WriteLine("Congratulations! You passed!");
        } else 
        {
            Console.WriteLine("Oops, sorry, try again later!");
        }
    }
}