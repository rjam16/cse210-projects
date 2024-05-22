using System;

class Program
{
    static void Main(string[] args)
    {
        string reply = "0";
        Console.Write("Welcome to the Mindfulness Program!");
        while (reply != "5")
        {
            Console.Write("\nPlease select one of the following choices: \n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Load File\n5. Save File\n6. Quit");
            Console.Write("\nWhat would you like to do? ");
            reply = Console.ReadLine();
            if (reply == "1")
            {
                BreathingActivity.Run();
            }
            else if (reply == "2")
            {
                ReflectingActivity.Run();
            }
            else if (reply == "3")
            {
                ListingActivity.Run();
            }
            else if (reply == "4")
            {
                ListingActivity.Run();
            }
           
            else if (reply == "5")
            {
                ListingActivity.Run();
            }
            else
            {
                break;
            }
            
        }
        Console.Write("See you next time!");
    }
}