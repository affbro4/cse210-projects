class BaseActivity
{

    private int _duration;
    private DateTime _endTime;
    public BaseActivity()
    {
        _duration = 30; // Replace with call to obtainDuration();
    }

    public void StartActivity()
    {
        // COMPLETE
    }
    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }


    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }
    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>0; i--)
        {

            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(750);   
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(seconds);
        Console.Write($"{message} ");
        string spinnerAnimation = "-\\|/";
        int index = 0;
        for (int i=0; i<20; i++)
        {
            Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
            Console.Write("\b");
            Thread.Sleep(300);
        }
        Console.Clear();
        Console.CursorVisible = true;
    }
}