using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int intgrade = int.Parse(grade);
        string letter = "";
        if (intgrade>=90)
        {
            // Console.WriteLine("A");
            letter = "A";
        }
        else if (intgrade >= 80)
        {
            // Console.WriteLine("B");
            letter = "B";
        }
        else if (intgrade >= 70)
        {
            // Console.WriteLine("C");
            letter = "C";
        }
        else if (intgrade >= 60)
        {
            // Console.WriteLine("D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("F");
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}");
        if (intgrade >= 70)
        {
            
            Console.WriteLine("Congratulation you pass");
        }
        else
        {
            
            Console.WriteLine("You Fail");
        }
    
    }
}