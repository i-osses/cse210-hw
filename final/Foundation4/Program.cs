using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        Activity running = new Running(new DateTime(2024, 11, 3), 30, 4.8);
        Activity cycling = new Cycling(new DateTime(2024, 11, 3), 45, 20.0);
        Activity swimming = new Swimming(new DateTime(2024, 11, 3), 25, 30);

        Activity[] activities = { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine($"Example of {activity.GetType().Name}");
            Console.WriteLine(activity.GetSummary());

        }
        Console.WriteLine();

    }
}