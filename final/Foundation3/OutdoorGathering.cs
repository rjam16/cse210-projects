using System;
class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public string GenerateWeatherStatement()
    {
        return $"The weather will be {_weather}.";
    }
    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }
    public string GenerateDetailedOutdoorGathering()
    {
        string details = "";
        string weatherStatement = GenerateWeatherStatement();
        details += GenerateStandard() + "\n";
        details += $"Statement of the Weather: {weatherStatement}";
        return details;
    }
    public string GenerateShortOutdoorGathering()
    {
        String shortOG = "";
        string eventType = ReturnEventType();
        shortOG += $"Event Type: {eventType}\n";
        return shortOG;
    }
}