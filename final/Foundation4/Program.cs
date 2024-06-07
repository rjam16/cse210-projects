using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        Running r1 = new Running("June 10, 2024", 35, 4.7);
        exerciseList.Add(r1);
        Bicycles b1 = new Bicycles("June 12, 2024", 45, 10);
        exerciseList.Add(b1);
        Swimming s1 = new Swimming("July 6, 2023", 15, 15);
        exerciseList.Add(s1);
        Console.WriteLine("Exercises: ");
        Console.WriteLine();
        foreach(Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}