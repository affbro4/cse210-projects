using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        int tries = 0;
        do
        {
        Console.WriteLine("What is the magic number? 6");
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine(); 
        num = int.Parse(guess);
        tries++;
        if (num > 6 )
            {
                Console.WriteLine("Lower");
            }
        else
            {
                Console.WriteLine("Higher");
            }
            
        }
        while (num != 6);
        {
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {tries} tries.");
       
        
        }
       

    }
}