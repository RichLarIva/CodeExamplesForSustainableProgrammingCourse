using System;

namespace HKRCodeExamples
{
    class Program
    {

        static Action<string> greet = name =>
        {
            string greeting = $"Hello, {name}";
            Console.WriteLine($"{greeting}! Enjoy your C#");
        };

        static Func<int, int> square = x => x * x;

        static Func<int, int> fibonacci = n => n < 2? n:fibonacci(n-1) + fibonacci(n -2);

        static string GreetName(string name)
        {
            string greeting = $"Hello, {name}";
            return $"{greeting}! Enjoy your regular method C#!";
        }

        static int SquareNumber(int x)
        {
            return x * x;
        }


        static void Main(string[] args)
        {
            string[] names = { "Reed", "Jonah", "Jerome", "Gina", "Daisy", "Gabriella" };
            int[] numbers = { 5, 2, 7, 8, 9, 19, 20 };
            foreach ( string name in names ) 
            {
                greet( name );
                GreetName( name );
            }
            foreach(int number in numbers )
            {
                Console.WriteLine($"{number} squared is {square(number)}");
                Console.WriteLine($"{number} squared using method is {SquareNumber(number)}");
            }
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"fibonacci of {i} is: {fibonacci(i)}");
            }
            
            Console.ReadLine();
        }
    }
}