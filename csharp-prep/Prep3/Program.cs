using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        string again = "yes";
        
        while (again == "yes")
        {
            Random randomGenerator = new Random();
            int magic_number = randomGenerator. Next(1, 100);
            int num_guesses = 0;
            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                string response = Console.ReadLine();
                guess = int.Parse(response);
                if (guess > magic_number)
                {
                    Console.Write("Lower, ");
                    num_guesses ++;
                }
                else if (guess < magic_number)
                {
                    Console.Write("Higher, ");
                    num_guesses ++;
                }
                else
                {
                    Console.Write("You guessed it! ");
                    Console.Write($"You guessed it in {num_guesses} tries! ");
                    Console.Write("Would you like to play again? ");
                    again = Console.ReadLine();
                }
            }
        }
        Console.Write("Thanks for playing!");
    }
}