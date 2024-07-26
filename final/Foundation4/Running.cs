public class Running : Activity
{
  private double _distance; // in kilometers

  public double Distance
  {
    get { return _distance; }
    set { _distance = value; }
  }

  public Running(DateTime date, int minutes, double distance)
      : base(date, minutes)
  {
    Distance = distance;
  }

  public override double GetDistance()
  {
    return Distance;
  }

  public override double GetSpeed()
  {
    return (Distance / Minutes) * 60;
  }

  public override double GetPace()
  {
    return Minutes / Distance;
  }
}
