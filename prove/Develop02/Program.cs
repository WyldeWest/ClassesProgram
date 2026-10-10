using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0; 
        SaveJournal theJournal = new SaveJournal();

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.CreateJournalEntry();
                    theJournal.AddEntry(newEntry);
                    break;
                case 2:
                    Console.WriteLine("Display");
                    theJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Save Journal");
                    Console.WriteLine("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    theJournal.WriteToFile(saveFile);
                    break;
                case 4:
                    Console.WriteLine("Read Journal");
                    Console.WriteLine("What is the filename? ");
                    string readFile = Console.ReadLine();
                    theJournal.ReadFromFile(readFile);
                    break;
            }
        }  
    }
}