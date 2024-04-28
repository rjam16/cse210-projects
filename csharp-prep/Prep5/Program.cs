using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
        static void DisplayWelcomeMessage()
        {
            Console.Write("Welcome to the Program!");

        }
        static string PromptUserName()
        {
            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNumber = Console.ReadLine();
            int userNumber = int.Parse(favNumber);
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber;
            return squaredNumber;
        }
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.Write($"{userName}, the square of your number is {squaredNumber}.");
        }
    }
}