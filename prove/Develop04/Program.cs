using System;

List<string> _activities = new List<string>();
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
        Console.Write("Enter the filename you wish to use: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(": ");

            string name = parts[0];
            string duration = parts[1];
        }
    }
    else if (reply == "5")
    {
        Console.Write("Enter the filename you wish to use: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Activity a in _activities)
            {
                Console.Write($"{Activity.GetActivityName()}:{Activity.GetDuration()}");
            }
        }
        Console.Write($"Session saved to {filename}");
    }
    else
    {
        break;
    }

}
Console.Write("See you next time!");
