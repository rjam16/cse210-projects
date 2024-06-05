using System;
class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points, bool complete) : base(name, description, points, complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _complete = complete;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }
    public override void RecordEvent()
    {
        if (_complete == false) {
            _complete = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }
    public override bool IsComplete()
    {
        if (_complete == true) 
        {
            return true;
        } 
        else 
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string line = "";
        line = $"SimpleGoal:{_shortName}, {_description} {_points}, {IsComplete().ToString()}";
        return line;
    }
    public override string GetStringRepresentation()
    {
        string lineDisplay = "";
        string statusSymbol = "";
        bool complete = IsComplete();
        if (complete == true) 
        {
            statusSymbol = "X";
        }
        else
        {
            statusSymbol = " ";
        }
        lineDisplay = $"[{statusSymbol}] {_shortName} - {_description}";
        return lineDisplay;
        
    }
    public override int CalculateTotalScore()
    {
        int total = 0;
        bool status = IsComplete();
        if(status == true)
        {
            total = int.Parse(_points);
        }
        else
        {
            total = 0;
        }
        return total;
    }
    public static string GetGoalName()
    {
        return _shortName;
    }
    public static string GetDescription() 
    {
        return _description;
    }
    public static string GetPoints()
    {
        return _points;
    }
    public static bool GetCompleteStatus()
    {
        return _complete;
    }
}