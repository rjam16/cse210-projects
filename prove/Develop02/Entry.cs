using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Entry
{
    DateTime currentTime = DateTime.Now;
    public Dt()
    {
        _date = currentTime;
    }
    public string _date = currentTime;
    public string _promptText = "";
    public string _entryText = "";
    public void Display()
    {
        Console.Write($"Date:{_date}, Prompt:{_promptText}, Entry: {_entryText}");

    }
}