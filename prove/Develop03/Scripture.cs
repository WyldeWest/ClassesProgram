class Scripture
{
    List<Word> _words;
    //todo add scripture reference


    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWords(text);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }

        return tempWords;
    }
}