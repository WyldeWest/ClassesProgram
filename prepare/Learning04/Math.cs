class Math : Assignment
{
    private string _textBookSelection;
    private string _problems;

    public Math(string studentName, string topic, string textBookSelection, string problems) 
       : base(studentName, topic)
    {
        _textBookSelection = textBookSelection;
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"Section {_textBookSelection} Problems: {_problems}";
    }
}