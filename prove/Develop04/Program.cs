using System;
using System.Text.Json;

List<Activity> _activities = new List<Activity>();
string reply = "0";
Console.Write("Welcome to the Mindfulness Program!");
while (reply != "5")
{
    Console.Write("\nPlease select one of the following choices: \n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Load File\n5. Save File\n6. Quit");
    Console.Write("\nWhat would you like to do? ");
    reply = Console.ReadLine();
    if (reply == "1")
    {
        BreathingActivity a1 = new BreathingActivity(Activity.GetActivityName(), Activity.GetDescription(), Activity.GetDuration());
        BreathingActivity.Run();
        _activities.Add(a1);
    }
    else if (reply == "2")
    {
        ReflectingActivity a2 = new ReflectingActivity(Activity.GetActivityName(), Activity.GetDescription(), Activity.GetDuration(), ReflectingActivity.GetPrompts(), ReflectingActivity.GetQuestions());
        ReflectingActivity.Run();
        _activities.Add(a2);
    }
    else if (reply == "3")
    {
        ListingActivity a3 = new ListingActivity(Activity.GetActivityName(), Activity.GetDescription(), Activity.GetDuration(), ListingActivity.GetCount(), ListingActivity.GetPrompts());
        ListingActivity.Run();
        _activities.Add(a3);
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
