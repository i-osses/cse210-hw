using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tesla";
        job1._startYear = 2022;
        job1._endYear = 2024;

        // Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "SpaceX";
        job2._startYear = 2023; 
        job2._endYear = 2024;

        // Console.WriteLine($"Job2: {job2._company}");

        job1.Display();
        job2.Display();

        Resume newResume= new Resume();
        newResume._name = "James Osses";

        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        // Console.WriteLine($"Test newResume: {newResume._jobs[0]._jobTitle}");

        newResume.Display();



    }
}