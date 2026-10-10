using System.IO.Enumeration;

class SaveJournal
{

    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void WriteToFile(string filename)
    {
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void ReadFromFile(string filename)

    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)

        {

            string[] parts = line.Split("#");

            string date = parts[0];

            string prompt = parts[1];

            string response = parts[2];

            JournalEntry entry = new JournalEntry(date, prompt, response);  

            this.AddEntry(entry);
        }
    }

}