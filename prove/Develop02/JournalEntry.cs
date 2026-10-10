class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    private List<string> _prompts = new List<string>
    {
        "How was your day?",
        "What was the best part of your day?",
        "What is something new you learned today?",
        "What is one thing you are grateful for today?",
        "What was the most interesting part of your day and how did it impact you?"
    };

    private Random _random = new Random();
    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public JournalEntry() { }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry()
    {
        _date = "October 10, 2026";
        int index = _random.Next(_prompts.Count);
        _prompt = _prompts[index];

        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();
    }

    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}