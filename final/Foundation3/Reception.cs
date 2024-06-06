using System;
class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }
    public string ReturnEventType()
    {
        return "Reception";
    }
    public string GenerateDetailedReception()
    {
        string details = GenerateStandard() + "\n";
        details += $"RSVP: {_email}";
        return details;
    }
    public string GenerateShortReception()
    {
        string shortR = "";
        string eventType = ReturnEventType();
        shortR += $"Event Type: {eventType}\n";
        shortR += GenerateShort();
        return shortR;
    }
}