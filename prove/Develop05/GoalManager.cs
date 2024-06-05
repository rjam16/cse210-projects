using System;
using System.IO;
class GoalManager
{
    protected static List<Goal> _goals = new List<Goal>();
    protected static int _score = 0;
    public GoalManager()
    {

    }
    public int GetScore()
    {
        int points =_score;
        return points;
    }
    public int CalculateScore()
    {
        int score = _score;
        foreach(Goal goal in _goals)
        {
            score += goal.CalculateTotalScore();
        }
        _score = score;
        return score;
    }
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoals()
    {
        Console.WriteLine("Your goals are as follow:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].GetStringRepresentation();
            Console.Write("\n");
        }
        Console.WriteLine();
    }
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void RecordEventInManager()
    {
        string goalIndex = "";
        Console.Write("Which goal was done? ");
        goalIndex = Console.ReadLine();
        int goalIndexNum = int.Parse(goalIndex) - 1;

        if (_goals[goalIndexNum].IsComplete() == false) {

            _goals[goalIndexNum].RecordEvent();

            int pointsEarned = _goals[goalIndexNum].CalculateTotalScore();

            _score += pointsEarned;

            Console.WriteLine($"Congrats! You earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_score} points!");

        } else 
        {
            Console.WriteLine("You already completed this goal.");
        }
    }
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the file you would like to use? ");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalScore = GetScore();
            outputFile.WriteLine(totalScore.ToString());
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        string fileName = "";
        Console.Write("What is the file you would like to use? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split("|");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3], Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "CheckListGoal")
            {
                CheckListGoal checklistGoal = new CheckListGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }
        }
    }
}