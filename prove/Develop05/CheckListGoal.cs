class ChecklistGoal : EternalQuest
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        bool status,
        string goalType,
        int amountCompleted,
        int target,
        int bonus)
        : base(name, description, points, status, goalType)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal() : base()
    {
        GoalType = "ChecklistGoal";
        _amountCompleted = 0;

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        while (!int.TryParse(Console.ReadLine(), out _target) || _target <= 0)
        {
            Console.Write("Please enter a positive whole number for the target: ");
        }

        Console.Write("What is the bonus for accomplishing it that many times? ");
        while (!int.TryParse(Console.ReadLine(), out _bonus) || _bonus < 0)
        {
            Console.Write("Please enter a valid whole number for the bonus: ");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"\n'{Name}' has already reached its target ({_amountCompleted}/{_target}).");
            return;
        }

        _amountCompleted++;
        int earned = Points;

        if (_amountCompleted >= _target)
        {
            MarkComplete();
            earned += _bonus;
            Console.WriteLine($"\nCongratulations! You completed '{Name}' ({_amountCompleted}/{_target}) and earned {Points} points plus a {_bonus}-point bonus!");
        }
        else
        {
            Console.WriteLine($"\nGreat progress! You recorded '{Name}' ({_amountCompleted}/{_target}) and earned {earned} points.");
        }
    }

    public override string GetDetails()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetRep()
    {
        return $"ChecklistGoal:{Name}:{Description}:{Points}:{Status}:{_bonus}:{_target}:{_amountCompleted}";
    }
}