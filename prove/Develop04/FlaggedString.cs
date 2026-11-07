class FlaggedString
{
    public string Text { get; set; }
    public bool IsUsed { get; set; }

    public FlaggedString(string text)
    {
        Text = text;
        IsUsed = false;
    }
}