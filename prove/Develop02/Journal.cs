using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry anEntry = new Entry();
        anEntry._date = "05/11/2024";
        PromptGenerator aPrompt = new PromptGenerator();
        string Prompt = aPrompt.GetRandomPrompt();
        anEntry._promptText = Prompt;
        Console.Write(Prompt);
        string entry = Console.ReadLine();
        anEntry._entryText = entry;
        _entries.Add(anEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter the filename you wish to use: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries) {
                Console.Write($"{entry._date}{entry._promptText}\n{entry._entryText}");
            }
        }
        Console.Write($"Entries saved to {filename}");
    }
    public void LoadFromFile()
    {
        Console.Write("Enter the filename you wish to use: ");
        string filename = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts =line.Split("; ");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
        }
    }

}