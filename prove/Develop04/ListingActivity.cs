using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
class ListingActivity : Activity
{
    protected static int _count;
    private static string[] input = {"List your favorite things: ", "Create a Dream Travel List: ", "Write a List of Hobbies to Try: ", "List some Family Traditions or Family Memories: ", "Write Down Things That Make You Happy: ", "Write Things That Make You Sad: ", "Plan Activities for a Rainy Day: ", "Write More Self-Care Ideas: "};
    protected static List<string> _prompts = new List<string>(input);

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
        _name = "Welcome to the Listing Activity.";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public static void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            ShowSpinner(GetDuration());
            Console.Write(GetRandomPrompt());
            GetListFromUser();
        }
        DisplayEndingMessage();
    }

    public static string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public static List<string> GetListFromUser()
    {
        bool end = false;
        List<string> userInput = new List<string>();
        int listSize = 0;
        while (!end)
        {
            Console.Write("Please Enter Your List (type end when finished):");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "end")
            {
            break;
            }
            else
            {
                userInput.Add(answer);
                listSize += 1;
            }
        }
        string size = "You have {listSize} items in your list.";
        userInput.Add(size);
        return userInput;
    }
    public static int GetCount()
    {
        return _count;
    }
    public static List<string> GetPrompts()
    {
        return _prompts;
    }
}