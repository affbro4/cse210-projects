using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunActivity();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunActivity();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunActivity();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}