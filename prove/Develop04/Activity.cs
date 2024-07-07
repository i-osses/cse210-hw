using System;

public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public string Name
  {
    get { return _name; }
    set { _name = value; }
  }

  public int Duration
  {
    get { return _duration; }
    set { _duration = value; }

  }

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;

  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}\n");
    Console.WriteLine($"{_description}\n");
    Console.Write($"How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.Write("Get ready...\n");

  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!");
    ShowSpinner(6);
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    ShowSpinner(6);

  }

  public void ShowSpinner(int seconds)
  {
    List<String> animationSpinner = new List<String>
    {
    "|", "/", "-", "\\", "|", "/", "-", "\\"
    };

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string s = animationSpinner[i];
      Console.Write(s);
      Thread.Sleep(500);
      Console.Write("\b \b");
      i++;
      if (i >= animationSpinner.Count)
      {
        i = 0;
      }
    }
    Console.WriteLine("");
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}