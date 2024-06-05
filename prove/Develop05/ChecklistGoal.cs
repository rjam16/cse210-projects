class CheckListGoal : Goal
{
    protected static int _amountCompleted;
    protected static int _target;
    protected static int _bonus;
    public CheckListGoal(string name, string description, string points, int target, int bonus, int completion) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _target = target;
        _amountCompleted = completion;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target) 
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
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        _target = int.Parse(stringChecklistSteps);

        Console.Write("What is the bonus for completing the desired amount? ");
        string bonusPoints = Console.ReadLine();
        _bonus = int.Parse(bonusPoints);

        string line = " ";
        line = $"ChecklistGoal: {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
        return line;

    }
    public override string GetStringRepresentation()
    {
        string lineDisplay = "";
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true)
        {
            statusSymbol = "X";
        }
        else
        {
            statusSymbol = " ";
        }
        lineDisplay = $"[{statusSymbol}] {_shortName} ({_description}) -- Completion Ration {_amountCompleted}/{_target}";
        return lineDisplay;
    }
    public override int CalculateTotalScore()
    {
        int total = 0;
        total = _amountCompleted * int.Parse(_points);
        bool status = IsComplete();
        if(status == true)
        {
            total += _bonus;
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
    public static int GetBonus()
    {
        return _bonus;
    }
    public static int GetTarget() 
    {
        return _target;
    }
    public static int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}