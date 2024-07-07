public class BreathingActivity : Activity
{
  public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {
  }

  public void Run()
  {
    DisplayStartingMessage();
    ShowCountDown(5);

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(Duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("Breathe in... ");
      ShowCountDown(3);
      Console.WriteLine("");
      Console.Write("Breathe out... ");
      ShowCountDown(3);
      Console.WriteLine("\n");
    }
    DisplayEndingMessage();
  }
}
