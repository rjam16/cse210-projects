using System;
using System.Collections.Generic;
class ScriptureGenerator
{
    public static string[] input = {"Who was the most interesting person I interacted with today? ","What was the best part of my day? ","How did I see the hand of the Lord in my life today? ","What was the strongest emotion I felt today? ","If I had one thing I could do over today, what would it be? "};
    public List<string> _scriptures = new List<string>(input);
    public string GetRandomScripture()
    {
        var random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}