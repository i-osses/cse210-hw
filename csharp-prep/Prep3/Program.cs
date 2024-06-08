using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What's the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Random randomGenerator = new Random();

        string response;
        do
        {
        int magicNumber = new Random().Next(1,11);
        Console.Write("What is your guess? ");
        int guessedNumber = int.Parse(Console.ReadLine());
        int counter= 1;
        while (magicNumber != guessedNumber)
        {
            counter++;
            if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("Lower");
            }
            
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"{counter} tries");
        Console.Write("Do you want to play again? ");
        response = Console.ReadLine();

        }while (response == "yes");
    }
}