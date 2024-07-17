public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, string points)
      : base(name, description, points)
  {
  }

  public override void RecordEvent()
  {
  }

  public override bool IsComplete()
  {
    return false;
  }

  // public override string GetDetailsString()
  // {
  //   return $"EternalGoal: {ShortName}, {Description}, {Points}";
  // }

  public override string GetStringRepresentation()
  {

    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {ShortName} ({Description})";
  }
}