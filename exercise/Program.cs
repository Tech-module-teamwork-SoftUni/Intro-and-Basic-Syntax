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

