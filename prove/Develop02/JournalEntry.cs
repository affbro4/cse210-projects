
using System;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor for creating a journal entry from a file
    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Default constructor
    public JournalEntry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public void CreateJournalEntry()
    {
        string[] prompts =
        {
            "What are three things you are grateful for?",
            "What is something small that made you happy today?",
            "What is something you sometimes take for granted?",
            "When did you feel peaceful today?",
            "What is something good that happened unexpectedly?"
        };

        Random random = new Random();
        _prompt = prompts[random.Next(prompts.Length)];

        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine() ?? "";
    }

    public override string ToString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}
