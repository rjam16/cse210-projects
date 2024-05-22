class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    static void DisplayStartingMessage()
    {}

    static void DisplayEndingMessage()
    {}

    static void ShowSpinner(int seconds)
    {}

    static void ShowCountDown(int seconds)
    {}
}