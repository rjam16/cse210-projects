using System;
class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lecture";
    }
    public string GenerateDetailedLecture()
    {
        string details = GenerateStandard() + "\n";
        details += $"Speaker: {_speaker}\n";
        details += $"Capacity: {_capacity} max";
        return details;
    }
    public string GenerateShortLecture()
    {
        string shortLecture = "";
        string eventType = ReturnEventType();
        shortLecture += $"Event Type: {eventType}\n";
        shortLecture += GenerateShort();
        return shortLecture;
    }
}