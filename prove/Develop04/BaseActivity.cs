using System;
using System.Threading;

class BaseActivity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        RunSpinnerMessage("", 3);
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        RunSpinnerMessage("You have completed another great activity", 3);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_activityName}.");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        RunSpinnerMessage("Well done!", 3);
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;

        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i}   ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;

        string spinner = "|/-\\";
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        Console.Write(message + " ");

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index++ % spinner.Length]);
            Console.Write("\b");
            Thread.Sleep(250);
        }

        Console.WriteLine();
        Console.CursorVisible = true;
    }
}