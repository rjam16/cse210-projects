using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
class ReflectingActivity : Activity
{
    public static string[] input = {"Think of a time you really struggled. ","Remember a time when you felt happiest. ","Think of a time you helped someone else.", "Consider a time you went through a major life change."};

    protected static List<string> _prompts = new List<string>(input);

    public static string[] thoughts = {"Why is this moment meaningful for you? ","What did you learn about yourself from this experience? ","How did you feel afterward?", "What impact do you think this will have on your future?"};

    protected static List<string> _questions = new List<string>(thoughts);

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        _name = "Welcome to the Reflecting Activity.";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
            DisplayPrompt();
            Thread.Sleep(2000);
            DisplayQuestions();
            Thread.Sleep(2000);
        }
        DisplayEndingMessage();
    }

    public static string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public static string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    static void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.Write("---");
        Console.Write(GetRandomPrompt());
        Console.Write("---");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        
    }

    static void DisplayQuestions()
    {
        Console.WriteLine($">{GetRandomQuestion()}");
        Console.WriteLine($">{GetRandomQuestion()}");
    }
    public static List<string> GetPrompts()
    {
        return _prompts;
    }
    public static List<string> GetQuestions()
    {
        return _questions;
    }
}