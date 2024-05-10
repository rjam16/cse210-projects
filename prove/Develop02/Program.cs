using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        string reply = "0";
        Console.Write("Welcome to the Journal Program!");
        while (reply != "5")
        {
            Console.Write("Please select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            reply = Console.ReadLine();
            if (reply == "1")
            {
                Journal.AddEntry(anEntry);
            }
            else if (reply == "2")
            {
                Journal.DisplayAll();
            }
            else if (reply == "3")
            {
                Journal.LoadFromFile();
            }
            else if (reply == "4")
            {
                Journal.SaveToFile(fileName);
            }
            else
            {
                break;
            }
            
        }
        Console.Write("See you next time!");
        
    }
}