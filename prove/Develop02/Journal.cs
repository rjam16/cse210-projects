using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string fileName = "myJournal.csv";
    public void AddEntry(Entry anEntry)
    {
        PromptGenerator aPrompt = new PromptGenerator();
        string Prompt = aPrompt.GetRandomPrompt();
        Console.Write(Prompt);
        string entry = Console.ReadLine();

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
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries) {
                Console.Write($"{entry._date}{entry._promptText}\n{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        string [] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts =line.Split(", ");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
        }
    }

}