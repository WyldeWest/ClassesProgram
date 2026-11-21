public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    public void DisplayGoalCreation()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    public int GetChoice()
    {
        Console.Write("Select a choice from the menu: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.Write("Please enter a valid number: ");
        }
        return choice;
    }
}