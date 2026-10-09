using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                    case 1:
                        myJournal.CreateEntry();
                        // Call CreateJournalEntry()
                        break;
                    case 2: 
                        myJournal.DisplayJournal();
                        // Call DisplayJournal()
                        break;
                    case 3:
                    Console.Write("Enter the filename to save to: ");
                    string saveFile = Console.ReadLine();
                    myJournal.WriteToFile(saveFile);
                
                        // Call ReadFromFile()
                        break;
                    case 4:
                        Console.Write("Enter the filename to read from: ");
                        string readFile = Console.ReadLine();
                        myJournal.ReadFromFile(readFile);
                        // Call WriteToFile
                        break;
            }
        }
    }
}