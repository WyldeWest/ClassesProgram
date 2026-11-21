class SimpleGoal : EternalQuest
{
    public SimpleGoal(string name, string description, int points, bool status, string goalType) : 
    base(name, description, points, status, goalType)
    {
        
    }
    public SimpleGoal() : base()
    {
    }

    public override void RecordEvent()
    {
        if (!Status)
        {
            MarkComplete();
            Console.WriteLine($"\nCongratulations! You completed '{Name}' and earned {Points} points!");
        }
        else
        {
            Console.WriteLine($"\n'{Name}' has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return Status;
    }

    public override string GetDetails()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {Name} ({Description})";
    }

    public override string GetRep()
    {
        return $"SimpleGoal:{Name}:{Description}:{Points}:{Status}";
    }
}