using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
class ReflectingActivity : Activity
{
    public static string[] input = {"Think of a time you really struggled. ","Remember a time when you felt happiest. ","Think of a time you helped someone else.", "Consider a time you went through a major life change."};

    private static List<string> _prompts = new List<string>(input);

    public static string[] thoughts = {"Why is this moment meaningful for you? ","What did you learn about yourself from this experience? ","How did you feel afterward?", "What impact do you think this will have on your future?"};

    private static List<string> _questions = new List<string>(thoughts);

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        name = "Welcome to the Reflecting Activity.";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
    }

    public static void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(Activity.GetDuration());
        DisplayPrompt();
        DisplayQuestions();
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
}