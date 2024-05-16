using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;

class myProgram
{
    static void Main(string[] args)
    {
        private static List<string> hiddenWords = new List<string>();
        Scripture scripture = new Scripture();
        ScriptureGenerator aScripture = new ScriptureGenerator();
        string myScripture = aScripture.GetRandomScripture();
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            GetDisplayText(myScripture);

            Console.Write("Please press enter continue or type 'quit' to finish: ");
            string response = Console.ReadLine();
        }
        if (response.ToLower() == "quit")
        {
            quit = true;
        }
        else
        {
            HideRandomWords(myScripture);
        }
    }
}