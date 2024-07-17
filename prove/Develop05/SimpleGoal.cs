public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string goalName, string goalDescription, string points) : base(goalName, goalDescription, points)
  {
    _isComplete = false;
  }


  public override void RecordEvent()
  {
    _isComplete = true;
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  // public override string GetDetailsString()
  // {
  //   bool status = IsComplete();
  //   return $"SimpleGoal: {ShortName}, {Description}, {Points}, {status}";
  // }

  public override string GetStringRepresentation()
  {
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {ShortName} ({Description})";
  }
}