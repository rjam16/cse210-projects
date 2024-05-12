using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public void Display()
    {
        Console.Write($"Date:{_date}; Prompt:{_promptText}; Entry: {_entryText}");
    }
}