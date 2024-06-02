class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Welcome to the Breathing Activity.";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public static void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            ShowSpinner(GetDuration());
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Thread.Sleep(2000);
            Console.WriteLine("And breathe out...");
            ShowCountDown(6);
            Thread.Sleep(2000);
        }
        DisplayEndingMessage();
    }
}