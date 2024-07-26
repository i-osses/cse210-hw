public class OutdoorGathering : Event
{
  private string _weather;

  public string Weather
  {
    get { return _weather; }
    set { _weather = value; }
  }

  public OutdoorGathering(string title, string description, DateTime date, string time, Address location, string weather)
      : base(title, description, date, time, location)
  {
    Weather = weather;
  }

  public override string GetFullDetails()
  {
    return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
  }

  public override string GetShortDescription()
  {
    return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
  }
}
