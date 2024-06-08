using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("enter number ");
        int number = int.Parse(Console.ReadLine());
        int largest = int.MinValue;
        int smallesPositive = int.MaxValue;
        
        while(number != 0)
        {
            if(number > largest)
            {
                largest = number;
            }
         
            if (number > 0 && number < smallesPositive)
            {
                smallesPositive = number;
            }
            Console.Write("Enter number ");
            numbers.Add(number);
            number = int.Parse(Console.ReadLine());
    
        }
        // Console.WriteLine("The numbers on the list are: ");
        float sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
            
        }   
        int numbersLen = numbers.Count;
        double av = sum / numbersLen;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {av}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallesPositive}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach(int n in numbers)
        {
            Console.WriteLine("" + n);
        }


    }
}