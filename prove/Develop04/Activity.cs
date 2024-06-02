class Activity {
    protected static string _name;
    protected static string _description;
    protected static int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public static string GetActivityName()
    {
        return _name;
    }
    public static string GetDescription() 
    {
        return _description;
    }
    public static int GetDuration()
    {
        return _duration;
    }
    public void SetActivityName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public static void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine(_duration);
    }

    public static void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed {_duration} of the {_name}.");
    }

    public static void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add(@"\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add(@"\");

        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    

    public static void ShowCountDown(int seconds)
    {
         for (int i = seconds; i > seconds; i--)
         {
            Console.WriteLine($"{seconds}");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
         }
    }
}