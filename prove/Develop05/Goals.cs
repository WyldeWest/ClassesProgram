using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    private List<EternalQuest> _goals = new List<EternalQuest>();
    private int _score = 0;

    public int Score => _score;

    public void Start()
    {
        Menu menu = new Menu();
        int choice = 0;

        while (choice != 6)
        {
            DisplayPlayerInfo();
            menu.DisplayMenu();
            choice = menu.GetChoice();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 1-6.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score} points");
    }

    public void CreateGoal()
    {
        Menu menu = new Menu();
        menu.DisplayGoalCreation();
        int goalChoice = menu.GetChoice();

        switch (goalChoice)
        {
            case 1:
                _goals.Add(new SimpleGoal());
                break;
            case 2:
                _goals.Add(new EternalGoal());
                break;
            case 3:
                _goals.Add(new ChecklistGoal());
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal was not created.");
                break;
        }
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        EternalQuest goal = _goals[index - 1];
        int pointsBefore = goal.Points;
        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();

        if (goal is ChecklistGoal)
        {
            if (!wasComplete)
            {
                _score += pointsBefore;
            }
        }
        else if (goal is EternalGoal)
        {
            _score += pointsBefore;
        }
        else if (goal is SimpleGoal && !wasComplete && goal.IsComplete())
        {
            _score += pointsBefore;
        }

        DisplayScore();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (EternalQuest goal in _goals)
            {
                outputFile.WriteLine(goal.GetRep());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? "goals.txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            return;
        }

        _goals.Clear();
        int.TryParse(lines[0], out _score);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            if (parts.Length == 0)
            {
                continue;
            }

            string goalType = parts[0];

            if (goalType == "SimpleGoal" && parts.Length >= 5)
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, status, goalType));
            }
            else if (goalType == "EternalGoal" && parts.Length >= 4)
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                _goals.Add(new EternalGoal(name, description, points, false, goalType));
            }
            else if (goalType == "ChecklistGoal" && parts.Length >= 8)
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int amountCompleted = int.Parse(parts[7]);
                _goals.Add(new ChecklistGoal(name, description, points, status, goalType, amountCompleted, target, bonus));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}