using System;

class Program
{
    // static double AddNumbers(double x, int y)
    // {
    //     // Console.WriteLine(x);
    //     return x + y;
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you");
    // }

    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        
        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);


      
    }
}




  // string myName = MyName();
        // DisplayGreeting(myName);
        // double total = AddNumbers(12.234, 20);
        // Console.WriteLine(total);



        // int x = 10;
        // int y = 30;
        // int z = 40;
        // if (x == 10 && y == 30 || z == 30)
        // {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is fun");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default Output");
        // }
        // string num = "123";
        // int mynumber = int.Parse(num);

        // While Loops
        // bool done = false; 
        
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)?");
        //     done = Console.ReadLine() == "y";
        // }


        // bool done; 
        
        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // } while (! done); 

        // For loop
        // for(double i = 0; i < 1.0; i+= 0.01)
        // {
        //     Console.WriteLine(i);
        // }

        // Lists List <int> = new List<int>()
        // List<string> myFriends = new List<string>  {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }



        // Functions 



// This is a comment 

/* 
    This is a 
    Multiline 
    comment
*/