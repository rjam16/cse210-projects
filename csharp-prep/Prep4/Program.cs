using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int new_number = 1;
        int sum = 0;
        int large_number = 0;
        Console.Write("Enter a list of numbers, type 0 when finished. \n");
        while (new_number != 0)
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            new_number = int.Parse(answer);
            if (new_number != 0)
            {
                numbers.Add(new_number);
            }

        }
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.Write($"\nThe sum is: {sum}. ");
        float average = sum / numbers.Count;
        Console.Write($"\nThe average is: {average}. ");
        foreach (int number in numbers)
        {
            if (number > large_number)
            {
                large_number = number;
            }
            else
            {
                continue;
            }
        }
        Console.Write($"\nThe largest number is: {large_number}");
    }
}