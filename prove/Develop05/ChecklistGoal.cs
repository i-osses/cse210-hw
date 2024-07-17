public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus)
      : base(name, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
  }

  public int AmountCompleted
  {
    get { return _amountCompleted; }
    set { _amountCompleted = value; }
  }

  public int Bonus
  {
    get { return _bonus; }
    set { _bonus = value; }
  }

  public int Target
  {
    get { return _target; }
    set { _target = value; }
  }

  public override void RecordEvent()
  {
    if (_amountCompleted < _target)
    {
      _amountCompleted++;
    }
  }

  public override bool IsComplete()
  {
    return _amountCompleted >= _target;
  }

  public override string GetDetailsString()
  {
    string className = this.GetType().Name;
    return $"{className}: {ShortName}, {Description}, {Points}, {_bonus}, {_target}, {_amountCompleted}";
  }

  public override string GetStringRepresentation()
  {
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {ShortName} ({Description}) -- Currently completed: {_amountCompleted}/{_target}  ";
  }
}
