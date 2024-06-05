class EternalGoal : Goal
{
    private int _steps;
    public EternalGoal(string name, string description, string points): base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }
    public override void RecordEvent()
    {
        _steps ++;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        string line = "";
        line = $"EternalGoal:{_shortName}, {_description}, {_points}";
        return line;
    }
    public override string GetStringRepresentation()
    {
        string lineDisplay = $"[] {_shortName} ({_description}";
        return lineDisplay;
    }
    public override int CalculateTotalScore()
    {
        int total = int.Parse(_points);
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
}