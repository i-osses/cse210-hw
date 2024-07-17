using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Develop05 World!"); */

        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        // Example usage
        // goalManager.CreateGoal("simple", "Run Marathon", "Complete a marathon", "1000");
        // goalManager.CreateGoal("eternal", "Read Scriptures", "Read scriptures every day", "100");
        // goalManager.CreateGoal("checklist", "Temple Attendance", "Attend the temple 10 times", "50", 10, 500);

        // goalManager.RecordEvent("Run Marathon");
        // goalManager.RecordEvent("Read Scriptures");
        // goalManager.RecordEvent("Temple Attendance");
        // goalManager.RecordEvent("Temple Attendance");

        // goalManager.DisplayPayerInfo();
        // goalManager.ListGoalNames();
        // goalManager.ListGoalDetails();

        // goalManager.SaveGoals("goals.txt");
        // goalManager.LoadGoals("goals.txt");
    }

}