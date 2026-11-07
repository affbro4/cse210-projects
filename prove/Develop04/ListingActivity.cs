using System;
using System.Collections.Generic;

class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;

    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<FlaggedString>();

        SetPrompts();
    }

    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompts[promptIndex].GetPrompt());

        RunCountDownMessage("You may begin in...", 5);

        Console.WriteLine();
        Console.WriteLine("Start listing items (press Enter after each item):");

        StartTimer();

        int count = 0;

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");

        EndActivity();
    }

    private void SetPrompts()
    {
        _prompts.Add(new FlaggedString(
            "Who are people that you appreciate?", false));

        _prompts.Add(new FlaggedString(
            "What are personal strengths of yours?", false));

        _prompts.Add(new FlaggedString(
            "Who are people that you have helped this week?", false));

        _prompts.Add(new FlaggedString(
            "When have you felt the Holy Ghost this month?", false));

        _prompts.Add(new FlaggedString(
            "Who are some of your personal heroes?", false));
    }
}