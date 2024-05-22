using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
class ListingActivity : Activity
{
    private int _count;
    private static string[] input = {"List your favorite things: ", "Create a Dream Travel List: ", "Write a List of Hobbies to Try: ", "List some Family Traditions or Family Memories: ", "Write Down Things That Make You Happy: ", "Write Things That Make You Sad: ", "Plan Activities for a Rainy Day: ", "Write More Self-Care Ideas: "};
    private static List<string> _prompts = new List<string>(input);

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
        name = "Welcome to the Listing Activity.";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
    }

    public static void Run()
    {
        ListingActivity("Welcome to the Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration, count, prompts);
        GetRandomPrompt();
        GetListFromUser();
    }

    public static void GetRandomPrompt()
    {
        var random = new Random();
        random.Next(_prompts.Count);
        return;
    }

    public static List<string> GetListFromUser()
    {
        bool end = false;
        List<string> userInput = new List<string>();
        while (!end)
        {
            Console.Write("Please Enter Your List(type quit when finished):");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "end")
            {
            break;
            }
            else
            {
                userInput.Add(answer);
            }
        }
        return userInput;
    }
}