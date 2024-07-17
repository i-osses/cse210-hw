using System.Globalization;

public class Goal
{
  private string _shortName;
  private string _description;
  private string _points;

  public Goal(string name, string description, string points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }
  public string ShortName
  {
    get { return _shortName; }
    set { _shortName = value; }
  }

  public string Description
  {
    get { return _description; }
    set { _description = value; }
  }

  public string Points
  {
    get { return _points; }
    set { _points = value; }
  }

  public virtual void RecordEvent()
  {
  }

  public virtual bool IsComplete()
  {
    return false;
  }

  public virtual string GetDetailsString()
  {
    // return $"{_shortName} ({_description}) ";
    bool status = IsComplete();
    string className = this.GetType().Name;
    if (className == "SimpleGoal")
    {
      return $"{className}: {_shortName}, {_description}, {_points}, {status}";
    }
    else
    {
      return $"{className}: {_shortName}, {_description}, {_points}";
    }
  }

  public virtual string GetStringRepresentation()
  {

    string status = IsComplete() ? "[X]" : "[ ]";
    return $"GRAL {status} {ShortName} ({Description})";
  }
}