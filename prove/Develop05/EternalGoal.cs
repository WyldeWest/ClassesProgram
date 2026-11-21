class EternalGoal : EternalQuest
{
    public EternalGoal(string name, string description, int points, bool status, string goalType)
        : base(name, description, points, status, goalType)
    {
    }

    public EternalGoal() : base()
    {
        GoalType = "EternalGoal";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"\nNice work! You recorded '{Name}' and earned {Points} points!");
    }

    public override string GetDetails()
    {
        return $"[ ] {Name} ({Description})";
    }

    public override string GetRep()
    {
        return $"EternalGoal:{Name}:{Description}:{Points}";
    }
}