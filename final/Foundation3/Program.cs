using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("624 Squaw Creek St.", "Orlando", "FL 32822", "USA");
        Lecture l1 = new Lecture("Literature Analysis: The Perfect Short Story", "An evening of literary exploration with George Saunders", "September 13, 2024", "10AM", a1, "George Saunders", 130);
        Console.WriteLine();
        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(l1.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(l1.GenerateDetailedLecture());
        Console.WriteLine();
        Console.WriteLine(l1.GenerateShortLecture());
        Address a2 = new Address("744 Blackburn Street", "Miami", "FL 33172", "USA");
        Reception r1 = new Reception("Devotional for Young Single Adults", "Face to face with Elder David A. Bednar", "June 21, 2024", "6 PM", a2, "devotional@youngadult.com");
        Console.WriteLine();
        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(r1.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(r1.GenerateDetailedReception());
        Console.WriteLine();
        Console.WriteLine(r1.GenerateShortReception());
        Address a3 = new Address("240 S. Water St", "Henderson", "NV 89015", "USA");
        OutdoorGathering og1 = new OutdoorGathering("Aki Matsuri", "A Japanese Fall Festival", "October 12, 2024", "11AM", a3, "cloudy");
        Console.WriteLine();
        Console.WriteLine(og1.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(og1.GenerateDetailedOutdoorGathering());
        Console.WriteLine();
        Console.WriteLine(og1.GenerateShortOutdoorGathering());
    }
}