class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    //todo add scripture reference


    public ScriptureReference(string bookName, int chapter, int verse)
    {
        _book = bookName;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public ScriptureReference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _book = bookName;
        _chapter = chapter;   
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if(_endVerse == 0)
        {
            return $"{_book} {_chapter}: {_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        }
    }
}