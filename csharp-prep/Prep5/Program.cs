using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        float square = SquareNumber(number);
        DisplayResult(name, square);



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static float SquareNumber(int number)
        {
            float square = number * number;

            return square;
        }

        static void DisplayResult(string name, float square)
        {
             Console.WriteLine($"{name}, the square of your number is {square}");
        }
       
    }
}