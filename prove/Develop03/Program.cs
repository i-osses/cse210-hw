using System;

class Program
{
    static void Main(string[] args)
    {
        //reference for scripture and scripture instance
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";

        Scripture scripture = new Scripture(reference, text);

        // Loop

        while (true)
        {
            Console.Clear();

            Console.Write($"{scripture.Reference.GetDisplayText()} ");
            Console.WriteLine(scripture.GetDisplayText());

            // check hidden woeds
            if (scripture.IsCompletelyHidden())
            {
                // Console.WriteLine("Ended");
                break;
            }

            // prompt user input

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            //exit option 
            if (input.ToLower() == "quit")
            {
                break;
            }

            //Hide random words
            scripture.HideRandomWords(3);
        }
    }
}