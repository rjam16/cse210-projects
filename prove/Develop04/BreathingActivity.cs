class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) 
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        sessionTime = int.Parse(Console.ReadLine());
    }
    public static  void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");

        while (duration != 0) 
        {
            Activity.ShowSpinner(duration);
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