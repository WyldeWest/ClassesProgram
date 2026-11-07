class Listing : Activity
{
    private List<FlaggedString> _prompts;

    public Listing(string name, string description) : base(name, description)
    {
        _prompts = new List<FlaggedString>();
        SetPrompts();
    }

    private void SetPrompts()
    {
        _prompts.Add(new FlaggedString("Who are people that you appreciate?"));
        _prompts.Add(new FlaggedString("What are personal strengths of yours?"));
        _prompts.Add(new FlaggedString("Who are people that you have helped this week?"));
        _prompts.Add(new FlaggedString("When have you felt the Holy Ghost this month?"));
        _prompts.Add(new FlaggedString("Who are some of your personal heroes?"));
    }

    private void ResetPromptsUsage()
    {
        foreach (var prompt in _prompts)
        {
            prompt.IsUsed = false;
        }
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses you can to the following prompt:");

        var availablePrompts = _prompts.Where(p => !p.IsUsed).ToList();
        if (availablePrompts.Count == 0)
        {
            ResetPromptsUsage();
            availablePrompts = _prompts.Where(p => !p.IsUsed).ToList();
        }

        Random random = new Random();
        int index = random.Next(availablePrompts.Count);
        FlaggedString selectedPrompt = availablePrompts[index];
        selectedPrompt.IsUsed = true;

        Console.WriteLine($"\n--- {selectedPrompt.Text} ---");
        RunCountDownMessage("You may begin in", 5); 
        Console.WriteLine();

        
        StartTime();
        
        List<string> userItems = new List<string>();

        while (!HasTimerEnded())
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userItems.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items!");
        DisplayEnding();
    }
}
