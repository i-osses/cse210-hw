public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
  {
    _prompts = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
  }


  public void Run()
  {
    DisplayStartingMessage();
    ShowSpinner(5);
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.Write("--- ");
    GetRandomPrompt();
    Console.WriteLine(" ---");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    GetPrompts();
    Console.WriteLine($"You listed {_count} items!\n");
    DisplayEndingMessage();
  }

  public void GetRandomPrompt()
  {
    Random random = new Random();
    int randomIndex = random.Next(_prompts.Count);
    string gotPrompt = _prompts[randomIndex];
    Console.Write(gotPrompt);
  }

  public List<string> GetPrompts()
  {

    Console.WriteLine("");
    List<string> getPrompts = new List<string>();
    string newPrompt;

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(Duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      newPrompt = Console.ReadLine();

      if (!string.IsNullOrEmpty(newPrompt)) // Check for empty input
      {
        getPrompts.Add(newPrompt);
      }
    }
    _count = getPrompts.Count;
    return getPrompts;

  }
}