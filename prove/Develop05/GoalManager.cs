public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    Console.Clear();
    // DisplayPayerInfo();

    while (true)
    {
      DisplayPayerInfo();
      Console.WriteLine("Menu Options:");
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List Goals");
      Console.WriteLine("  3. Save Goals");
      Console.WriteLine("  4. Load Goals");
      Console.WriteLine("  5. Record Event");
      Console.WriteLine("  6. Quit");
      Console.Write("Select a choice from the menu: ");
      string choice = Console.ReadLine();

      string filePath = "";

      if (choice == "3" || choice == "4")
      {
        Console.Write("What is the filename for the goal file? ");
        filePath = Console.ReadLine();
      }

      switch (choice)
      {
        case "1":
          CreateGoal();
          break;
        case "2":
          Console.WriteLine("The goals are: ");
          ListGoalNames();
          // DisplayPayerInfo();
          break;
        case "3":
          SaveGoals(filePath);
          break;
        case "4":
          LoadGoals(filePath);
          // DisplayPayerInfo();
          break;
        case "5":
          RecordEvent();
          break;
        case "6":
          return; // Exit the loop and end the program
        default:
          Console.WriteLine("Invalid choice. Please select a valid option.");
          break;
      }
    }
  }

  public void DisplayPayerInfo()
  {
    Console.WriteLine($"\nYou have: {_score} points.\n");
  }

  public void ListGoalNames()
  {
    int index = 0;
    foreach (var goal in _goals)
    {

      string details = goal.GetStringRepresentation();
      index++;
      Console.WriteLine($"{index}. {details}");
      // Console.WriteLine(goal.GetStringRepresentation());
    }
  }

  public void ListGoalDetails()
  {
    foreach (var goal in _goals)
    {
      Console.WriteLine(goal.GetDetailsString());
    }
  }

  public void CreateGoal()
  {
    Console.WriteLine("The types of goals are: ");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("Wich type of goal would you like to create ");
    string selectedGoal = Console.ReadLine();

    Console.Write("what is the name of your goal: ");
    string name = Console.ReadLine();
    Console.Write("What is a short description of it: ");
    string description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    string points = Console.ReadLine();

    int target = 0;
    int bonus = 0;
    // for ChecklistGoal
    if (selectedGoal == "3")
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for accomplishing it that many times? ");
      bonus = int.Parse(Console.ReadLine());
    }

    switch (selectedGoal)
    {
      case "1":
        _goals.Add(new SimpleGoal(name, description, points));
        break;
      case "2":
        _goals.Add(new EternalGoal(name, description, points));
        break;
      case "3":
        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        break;
      default:
        Console.WriteLine("Invalid goal type");
        break;
    }
  }

  public void RecordEvent()
  {
    Console.WriteLine("The goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
    }

    Console.Write("Which goal did you accomplish? ");
    string input = Console.ReadLine();
    int selectedGoalIndex;

    // Validate user input
    if (int.TryParse(input, out selectedGoalIndex))
    {
      if (selectedGoalIndex > 0 && selectedGoalIndex <= _goals.Count)
      {
        Goal selectedGoal = _goals[selectedGoalIndex - 1];
        selectedGoal.RecordEvent();

        // Calculate points based on the type of goal
        int points = 0;

        if (selectedGoal is SimpleGoal)
        {
          points = int.Parse(selectedGoal.Points);
        }
        else if (selectedGoal is EternalGoal)
        {
          points = int.Parse(selectedGoal.Points);
        }
        else if (selectedGoal is ChecklistGoal)
        {
          // ChecklistGoal with bonus
          ChecklistGoal checklistGoal = selectedGoal as ChecklistGoal;
          points = int.Parse(checklistGoal.Points);
          if (checklistGoal.IsComplete())
          {
            points += checklistGoal.Bonus;
          }
        }
        // Update the score
        _score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You have earned {_score} points in total.");
      }
      else
      {
        Console.WriteLine("Select a valid goal number.");
      }
    }
    else
    {
      Console.WriteLine("Enter a valid number.");
    }
  }



  public void SaveGoals(string filePath)
  {
    using (StreamWriter writer = new StreamWriter(filePath))
    {
      writer.WriteLine(_score);
      foreach (var goal in _goals)
      {
        writer.WriteLine(goal.GetDetailsString());
      }
    }
  }

  public void LoadGoals(string filePath)
  {
    string filename = filePath;
    string[] lines = System.IO.File.ReadAllLines(filename);

    // Check if the file is empty
    if (lines.Length == 0) return;

    int initialPoints = int.Parse(lines[0]);
    _score = (initialPoints);

    foreach (string line in lines.Skip(1))
    {
      // Console.WriteLine(line);
      string[] parts = line.Split(new char[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);

      if (parts.Length < 4)
      {
        // Handle the error
        continue;
      }

      string goalType = parts[0].Trim();
      string goalName = parts[1].Trim();
      string goalDescription = parts[2].Trim();
      string goalPoints = parts[3].Trim();

      if (goalType == "ChecklistGoal" && parts.Length >= 7)
      {
        int goalBonus = int.Parse(parts[4].Trim());
        int goalTarget = int.Parse(parts[5].Trim());
        int amountCompleted = int.Parse(parts[6].Trim());
        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
        checklistGoal.AmountCompleted = amountCompleted;
        _goals.Add(checklistGoal);
      }
      else if (goalType == "SimpleGoal")
      {
        bool isCompleted = bool.Parse(parts[4].Trim());
        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
        if (isCompleted)
        {
          simpleGoal.RecordEvent();
        }

        _goals.Add(simpleGoal);
      }
      else if (goalType == "EternalGoal")
      {
        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
        _goals.Add(eternalGoal);
      }
    }
  }
}