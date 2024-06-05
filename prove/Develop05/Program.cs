using System;

class Program
{
    static void Main(string[] args)
    {
        string reply = "0";
        GoalManager goals = new GoalManager();
        while(reply != "6")
        {
            int points = goals.GetScore();
            Console.WriteLine($"You have {points} points so far.");
            Console.WriteLine();
            Console.Write("\nPlease select one of the following choices: \n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("\nWhat would you like to do? ");
            reply = Console.ReadLine();
            if (reply == "1")
            {
                Console.WriteLine("What type of Goal are you creating?");
                Console.Write("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.WriteLine();
                string category = Console.ReadLine();
                if (category == "1")
                {
                    SimpleGoal g1 = new SimpleGoal(SimpleGoal.GetGoalName(), SimpleGoal.GetDescription(), SimpleGoal.GetPoints(), SimpleGoal.GetCompleteStatus());
                    g1.CreateChildGoal();
                    goals.CreateGoal(g1);
                }
                else if (category == "2")
                {
                    EternalGoal g2 = new EternalGoal(EternalGoal.GetGoalName(),EternalGoal.GetDescription(), EternalGoal.GetPoints());
                    g2.CreateChildGoal();
                    goals.CreateGoal(g2);
                }
                else if (category == "3")
                {
                    CheckListGoal g3 = new CheckListGoal(CheckListGoal.GetGoalName(), CheckListGoal.GetDescription(), CheckListGoal.GetPoints(), CheckListGoal.GetTarget(), CheckListGoal.GetBonus(), CheckListGoal.GetAmountCompleted());
                    g3.CreateChildGoal();
                    goals.CreateGoal(g3);
                } 
            }
            else if (reply == "2")
            {
                goals.ListGoals();
            }
            else if (reply == "3")
            {
                goals.SaveGoals();
            }
            else if (reply == "4")
            {
                goals.LoadGoals();
            }
            else if (reply == "5")
            {
                goals.RecordEventInManager();
            }
            else
            {
                break;
            }
        }
    }
}