public abstract class Event
{
  private string _title;
  private string _description;
  private DateTime _date;
  private string _time;
  private Address _location;

  public string Title
  {
    get { return _title; }
    set { _title = value; }
  }

  public string Description
  {
    get { return _description; }
    set { _description = value; }
  }

  public DateTime Date
  {
    get { return _date; }
    set { _date = value; }
  }

  public string Time
  {
    get { return _time; }
    set { _time = value; }
  }

  public Address Location
  {
    get { return _location; }
    set { _location = value; }
  }

  public Event(string title, string description, DateTime date, string time, Address location)
  {
    Title = title;
    Description = description;
    Date = date;
    Time = time;
    Location = location;
  }

  public virtual string GetStandardDetails()
  {
    return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToString("dd MMM yyyy")}\nTime: {Time}\nAddress: {Location}";
  }

  public abstract string GetFullDetails();
  public abstract string GetShortDescription();
}
