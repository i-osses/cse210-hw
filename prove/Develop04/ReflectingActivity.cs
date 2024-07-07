using System;
public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
  {

    _prompts = new List<string>
      {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
      };

    _questions = new List<string>
      {
        "Why was this experience meaningful to you?",
        "How did you feel after accomplishing this task?",
        "What did you learn from this experience?",
        "How can you apply what you learned to other areas of your life?"
      };
  }
  public List<string> Prompts
  {
    get { return _prompts; }
    set { _prompts = value; }
  }

  public List<string> Questions
  {
    get { return _questions; }
    set { _questions = value; }
  }

  public void Run()
  {
    DisplayStartingMessage();
    ShowSpinner(5);

    Console.WriteLine("Consider the following prompt:\n");
    Console.Write("--- ");
    DisplayPrompt();
    Console.WriteLine(" ---\n");
    Console.Write("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.Write("Now ponder on each of te following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(Duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("> "); DisplayQuestions();
    }
    DisplayEndingMessage();
  }

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int randomIndex = random.Next(_prompts.Count);
    return _prompts[randomIndex];
  }

  public string GetRandomQuestion()
  {
    Random random = new Random();
    int randomIndex = random.Next(_questions.Count);
    return _questions[randomIndex];
  }

  public void DisplayPrompt()
  {
    string prompt = GetRandomPrompt();
    Console.Write(prompt);
  }

  public void DisplayQuestions()
  {
    string question = GetRandomQuestion();
    Console.Write(question);
    ShowSpinner(16);
    Console.WriteLine(" ");
  }
}