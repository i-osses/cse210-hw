public class Reception : Event
{
  private string _rsvpEmail;

  public string RsvpEmail
  {
    get { return _rsvpEmail; }
    set { _rsvpEmail = value; }
  }

  public Reception(string title, string description, DateTime date, string time, Address location, string rsvpEmail)
      : base(title, description, date, time, location)
  {
    RsvpEmail = rsvpEmail;
  }

  public override string GetFullDetails()
  {
    return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
  }

  public override string GetShortDescription()
  {
    return $"Type: Reception\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
  }
}
