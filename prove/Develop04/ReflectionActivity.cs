using System;
using System.Collections.Generic;

class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();

        SetPromptsAndQuestions();
    }

    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompts[promptIndex].GetPrompt());

        RunSpinnerMessage("Think about this...", 5);

        StartTimer();

        while (!HasTimerExpired())
        {
            int questionIndex = random.Next(_questions.Count);

            Console.WriteLine();
            Console.WriteLine(_questions[questionIndex].GetPrompt());

            RunSpinnerMessage("Reflect on this question", 8);
        }

        EndActivity();
    }

    private void SetPromptsAndQuestions()
    {
        _prompts.Add(new FlaggedString(
            "Think of a time when you stood up for someone else.", false));

        _prompts.Add(new FlaggedString(
            "Think of a time when you did something really difficult.", false));

        _prompts.Add(new FlaggedString(
            "Think of a time when you helped someone in need.", false));

        _prompts.Add(new FlaggedString(
            "Think of a time when you did something truly selfless.", false));


        _questions.Add(new FlaggedString(
            "Why was this experience meaningful to you?", false));

        _questions.Add(new FlaggedString(
            "Have you ever done anything like this before?", false));

        _questions.Add(new FlaggedString(
            "How did you get started?", false));

        _questions.Add(new FlaggedString(
            "How did you feel when it was complete?", false));

        _questions.Add(new FlaggedString(
            "What made this time different than other times when you were not as successful?", false));

        _questions.Add(new FlaggedString(
            "What is your favorite thing about this experience?", false));

        _questions.Add(new FlaggedString(
            "What could you learn from this experience that applies to other situations?", false));

        _questions.Add(new FlaggedString(
            "What did you learn about yourself through this experience?", false));

        _questions.Add(new FlaggedString(
            "How can you keep this experience in mind in the future?", false));
    }
}