using System;
    
class Program
{
    
    
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle(100);
        
        // myCircle.SetRadius(10);

        double area = myCircle.GetArea();

        Console.WriteLine(area);


    }
}






// static double FindSmallest(List<double> data)
// {
//     double smallest = data[0]
//     foreach (double d in data)
//     {
//         if (d< smallest )
//         {
//             smallest = d;
//         }
//     }
//     return smallest;
// }


// Console.WriteLine($"The smallest number is {FindSmallest}");