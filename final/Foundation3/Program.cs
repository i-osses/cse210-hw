using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Address firesideAddress = new Address("UT", "Salt Lake City", "50 N Temple", "84150");
        Event fireside = new Lecture("Family History Fireside", "A special fireside on family history and genealogy.", new DateTime(2024, 8, 15), "7:00 PM", firesideAddress, "Elder David A. Bednar", 200);

        Address weddingAddress = new Address("UT", "Provo", "123 University Ave", "84604");
        Event weddingReception = new Reception("Temple Wedding Reception", "Celebrating the temple marriage of Emily and Mark.", new DateTime(2024, 9, 1), "6:00 PM", weddingAddress, "rsvp@lds.org");

        Address outdoorEventAddress = new Address("UT", "St. George", "456 Red Rock Rd", "84770");
        Event outdoorGathering = new OutdoorGathering("Youth Conference BBQ", "Outdoor BBQ for the youth conference participants.", new DateTime(2024, 7, 30), "12:00 PM", outdoorEventAddress, "Sunny");

        Event[] events = { fireside, weddingReception, outdoorGathering };

        foreach (Event evt in events)
        {
            Console.WriteLine();
            Console.WriteLine($"     ----- Standard Details of {evt.GetType().Name} -----");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine($"     ----- Full Details of {evt.GetType().Name} -----");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine($"     ----- Short Description of {evt.GetType().Name} -----");
            Console.WriteLine(evt.GetShortDescription());

        }
        Console.WriteLine();
    }
}