public abstract class EternalQuest
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;
    public bool Status => _status;
    public string GoalType
    {
        get => _goalType;
        protected set => _goalType = value;
    }

    public EternalQuest(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _goalType = goalType;
    }

    public EternalQuest()
    {
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _status = false;
    }

    protected void MarkComplete()
    {
        _status = true;
    }

    protected void SetGoalName()
    {
        Console.Write("Please enter the name of the goal: ");
        _name = Console.ReadLine();
    }

    protected void SetGoalDescription()
    {
        Console.Write("Please enter the description of your goal: ");
        _description = Console.ReadLine();
    }

    protected void SetGoalPoints()
    {
        Console.Write($"Please enter the number of points for goal '{_name}': ");
        while (!int.TryParse(Console.ReadLine(), out _points))
        {
            Console.Write("Invalid input. Please enter a valid whole number for points: ");
        }
    }

    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string GetDetails();
    public abstract string GetRep();

}