using System;
using System.Collections.Generic;
public class Goal 
{
    protected static string _shortName;
    protected static string _description;
    protected static string _points;
    protected static bool _complete;
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _complete = false;

    }
    public Goal(string name, string description, string points, bool complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _complete = complete;

    }
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return _complete;
    }
    public virtual void CreateChildGoal()
    {

    }
    protected static void CreateBaseGoal()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.Write("Write a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        _points = Console.ReadLine();
        _complete = false;
    }
    public virtual string GetDetailsString()
    //get goal info
    {
        return $"{_shortName}: {_description} - {_points}";
    }
    public virtual string GetStringRepresentation()
    //display the goal
    {
        string line = "";
        return line;
    }
    public virtual int CalculateTotalScore()
    {
        return 0;
    }
    
}