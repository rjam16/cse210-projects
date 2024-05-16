using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class myProgram
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        string reply = "0";
        Console.Write("Welcome to the Journal Program!");
        while (reply != "5")
        {
            Console.Write("\nPlease select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("\nWhat would you like to do? ");
            reply = Console.ReadLine();
            if (reply == "1")
            {
                theJournal.AddEntry();
            }
            else if (reply == "2")
            {
                theJournal.DisplayAll();
            }
            else if (reply == "3")
            {
                theJournal.LoadFromFile();
            }
            else if (reply == "4")
            {
                theJournal.SaveToFile();
            }
            else
            {
                break;
            }
            
        }
        Console.Write("See you next time!");
        
    }
}