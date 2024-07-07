using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity act1 = new BreathingActivity();
        ReflectingActivity act2 = new ReflectingActivity();
        ListingActivity act3 = new ListingActivity();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflecting Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    act1.Run();
                    break;
                case "2":
                    act2.Run();
                    break;
                case "3":
                    act3.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Please select a valid option");
                    continue;
            }
        }
    }
}