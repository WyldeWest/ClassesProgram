class Breath : Activity 
{
    public Breath(string name, string description) : base(name, description)
    {}

    public void RunActivity()
    {
        StartActivity();

        StartTime();

        while(!HasTimerEnded())
        {
            RunCountDownMessage("Breathe in...", 4);

            if (HasTimerEnded())
            {
                break;
            }

            RunCountDownMessage("Breathe out", 6);

        }

        DisplayEnding();
    }
}