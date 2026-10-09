class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        AddEntry(newEntry);
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('#', 3);

            if (parts.Length == 3)
            {
                string date = parts[0];
                string question = parts[1];
                string entryText = parts[2];

                JournalEntry entry =
                    new JournalEntry(date, question, entryText);

                AddEntry(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}
