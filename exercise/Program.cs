using System;

namespace IntroandBasicSyntax
{


  public class StartUp
        {
            public static void Main(string[] args)
            {
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());
                var tretoNum = int.Parse(Console.ReadLine());
                var forthNum = int.Parse(Console.ReadLine());

                Console.WriteLine($"{firstNum:D4} {secondNum:D4} {tretoNum:D4} {forthNum:D4}");

            }
        }
        
    }

using System;

namespace RectangleArea
{
public class StartUp
{
public static void Main(string[] args)
{
var width = double.Parse(Console.ReadLine());
var height = double.Parse(Console.ReadLine());
var sum = width * height;
Console.WriteLine($"{sum:f2}");

}
}
}

using System;

namespace MilesToKm
{
public class StartUp
{
public static void Main(string[] args)
{
var miles = double.Parse(Console.ReadLine());
double km = miles * 1.60934;
Console.WriteLine($"{km:F2}");
}
}
}


