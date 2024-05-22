using System;
using System.Collections.Generic;
class ReflectingActivity : Activity
{
    private static string[] input = {"Who was the most interesting person I interacted with today? ","What was the best part of my day? ","How did I see the hand of the Lord in my life today? ","What was the strongest emotion I felt today? ","If I had one thing I could do over today, what would it be? "};

    private List<string> _prompts = new List<string>(input);

    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public static void Run()
    {}

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        
    }
    static void DisplayPrompt()
    {}

    static void DisplayQuestions()
    {}
}