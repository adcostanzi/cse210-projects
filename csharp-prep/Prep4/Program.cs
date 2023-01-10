using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string number;
        int userNumber;
        int total = 0;
        float average;
        int max = -9999;
        int min = 9999;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        do {
            Console.Write("Enter a number: ");
            number = Console.ReadLine();
            userNumber = int.Parse(number);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        } while (userNumber != 0);

        foreach (int num in numbers)
        {
            total = total + num; 
            if (max < num)
            {
                max = num;
            }
            if ((num > 0) && (num < min))
            {
                min = num;
            }
        }
        int count = numbers.Count;
        average = ((float)total) / count;
        Console.WriteLine($"The total sum is {total}, the average is {average} and the maximum is {max} and the smallest positive number is {min}.");
        Console.WriteLine("The sorted list:");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}