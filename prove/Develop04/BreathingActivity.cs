class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
    }
    public static  void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");

        while (Activity.GetDuration() != 0) 
        {
            Activity.ShowSpinner(Activity.GetDuration());
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Thread.Sleep(3000);
            Console.WriteLine("And breathe out...");
            ShowCountDown(6);
            Thread.Sleep(2000);
        }
        DisplayEndingMessage();
    }
}