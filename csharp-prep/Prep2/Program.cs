using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letter = "";
        if (percent == 90 || percent > 90)
        {
            letter = "A";
        }
        else if (percent == 80 || percent > 80)
        {
            letter = "B";
        }
        else if (percent == 70 || percent > 70)
        {
            letter = "C";
        }
        else if (percent == 60 || percent > 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is a(n) {letter}.");
        if (percent == 70 || percent > 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class, try harder next time!");
        }

    }
}