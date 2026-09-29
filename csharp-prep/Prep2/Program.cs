using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string grade;
        Console.WriteLine("What was your Grade Percent ");
        grade = Console.ReadLine();
        
        int gradenum = int.Parse(grade);

        if (gradenum >= 90)
        {
            Console.WriteLine("Your Grade is A");
            Console.WriteLine("You Passed the Class!! Good Job You!");
        }
        else if (gradenum >= 80)
        {
            Console.WriteLine("Your Grade is B");
            Console.WriteLine("You Passed the Class!! Good Job You!");
        }
        else if (gradenum >= 70)
        {
            Console.WriteLine("Your Grade is C");
            Console.WriteLine("You Passed the Class!! Good Job You!");
        }
        else if (gradenum >= 60 )
        {
            Console.WriteLine("Your Grade is D");
            Console.WriteLine("Sadly you did not pass the class");
        }

        else
        {
            Console.WriteLine("Your Inputted something wrong");
        }


    }
}