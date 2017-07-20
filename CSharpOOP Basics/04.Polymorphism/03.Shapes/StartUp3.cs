using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp3
{
    public static void Main()
    {
        Console.WriteLine("Enter radius: ");
        var n = int.Parse(Console.ReadLine());
        Circle circle = new Circle(n);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
    }
}
