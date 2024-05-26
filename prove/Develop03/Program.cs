using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;

class myProgram
{
    static void Main(string[] args)
    {
        private static List<string> hiddenWords = new List<string>();
        ScriptureGenerator aScripture = new ScriptureGenerator();
        myScripture = aScripture.GetRandomScripture();
        Scripture scripture = new Scripture();
        bool quit = false;

        while (quit != false)
        {
            Console.Clear();
            GetDisplayText(myScripture);

            Console.WriteLine("Please press enter continue or type 'quit' to finish: ");
            string response = Console.ReadLine();
        }
        if (string response.ToLower() == "quit")
        {
            quit = true;
        }
        else
        {
            HideRandomWords(myScripture);
        }
    }
}