public abstract class Activity
{
  private DateTime _date;
  private int _minutes;

  public DateTime Date
  {
    get { return _date; }
    set { _date = value; }
  }

  public int Minutes
  {
    get { return _minutes; }
    set { _minutes = value; }
  }

  protected Activity(DateTime date, int minutes)
  {
    Date = date;
    Minutes = minutes;
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public virtual string GetSummary()
  {
    return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
  }
}
