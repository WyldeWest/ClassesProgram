class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine();

        ObtainDuration();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinnerMessage("", 3);
    }

    public void DisplayEnding()
    {
        DisplaySpinnerMessage("Well Done", 3);
        DisplaySpinnerMessage($"Congrats! You have completed another {_duration} seconds of the {_name}.", 3);
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i=seconds; i>=1; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message}");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        //for(int i=0; i<seconds; i++)
        string spinner = "-\\|/";
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"{spinner[index++ % spinner.Length]}");
            Console.Write("\b");
            Thread.Sleep(200);
        }

        Console.CursorVisible = true;

    }

    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerEnded()
    {
        return DateTime.Now >= _endTime;
    }

    public void ObtainDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        string input = Console.ReadLine();
        if(int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            _duration = 30;
        }
    }
}