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
    public string GetActivityName()
    {
        return _name;
    }
    public string GetDescription() 
    {
        return _description;
    }
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
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
        Console.WriteLine(name);
    }

    public static void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed {duration} of the {name}.");
    }

    public static void ShowSpinner(int seconds)
    {
        while(seconds != 0)
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("--");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("--");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public static void ShowCountDown(int seconds)
    {
        CountdownEvent CountDown = new CountdownEvent(3);
         for (int i = 0; i < seconds; i++)
         {
            Console.WriteLine($"{seconds}");
            CountDown.Signal();
            Thread.Sleep(1000);
         }
    }
}