class Reflection : Activity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public Reflection(string name, string description) : base(name, description)
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();
        SetPromptsAndQuestions();
    }

    private void SetPromptsAndQuestions()
    {
        _prompts.Add(new FlaggedString("Think of a time when you stood up for someone else."));
        _prompts.Add(new FlaggedString("Think of a time when you did something really difficult."));
        _prompts.Add(new FlaggedString("Think of a time when you helped someone in need."));
        _prompts.Add(new FlaggedString("Think of a time when you did something truly selfless."));

        _questions.Add(new FlaggedString("Why was this experience meaningful to you?"));
        _questions.Add(new FlaggedString("Have you ever done anything like this before?"));
        _questions.Add(new FlaggedString("How did you get started?"));
        _questions.Add(new FlaggedString("How did you feel when it was complete?"));
        _questions.Add(new FlaggedString("What made this time different than other times when you were not as successful?"));
        _questions.Add(new FlaggedString("What is your favorite thing about this experience?"));
        _questions.Add(new FlaggedString("What could you learn from this experience that applies to other situations?"));
        _questions.Add(new FlaggedString("What did you learn about yourself through this experience?"));
        _questions.Add(new FlaggedString("How can you keep this experience in mind in the future?"));
    }

    private void ResetPromptsUsage()
    {
        foreach (var prompt in _prompts)
        {
            prompt.IsUsed = false;
        }
        foreach (var question in _questions)
        {
            question.IsUsed = false;
        }
    }

    public void RunActivity()
    {
    
        StartActivity();

        Console.WriteLine("Consider the following prompt:\n");

        var availablePrompts = _prompts.Where(p => !p.IsUsed).ToList();
        if (availablePrompts.Count == 0)
        {
            foreach (var p in _prompts) p.IsUsed = false;
            availablePrompts = _prompts.Where(p => !p.IsUsed).ToList();
        }

        Random random = new Random();
        int promptIndex = random.Next(availablePrompts.Count);
        FlaggedString selectedPrompt = availablePrompts[promptIndex];
        selectedPrompt.IsUsed = true;

        Console.WriteLine($"--- {selectedPrompt.Text} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDownMessage("You may begin in:", 5);
        Console.Clear();

        StartTime();

        while (!HasTimerEnded())
        {
            var availableQuestions = _questions.Where(q => !q.IsUsed).ToList();
            if (availableQuestions.Count == 0)
            {
                foreach (var q in _questions) q.IsUsed = false;
                availableQuestions = _questions.Where(q => !q.IsUsed).ToList();
            }

            int questionIndex = random.Next(availableQuestions.Count);
            FlaggedString selectedQuestion = availableQuestions[questionIndex];
            selectedQuestion.IsUsed = true;

            Console.Write($"> {selectedQuestion.Text} ");
            
            DisplaySpinnerMessage("", 8); 
            Console.WriteLine();

            if (HasTimerEnded())
            {
                break;
            }
        }

        DisplayEnding();
    }
}