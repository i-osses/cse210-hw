public class Address
{
  private string _state;
  private string _city;
  private string _street;
  private string _zipCode;

  public string State
  {
    get { return _state; }
    set { _state = value; }
  }

  public string City
  {
    get { return _city; }
    set { _city = value; }
  }

  public string Street
  {
    get { return _street; }
    set { _street = value; }
  }

  public string ZipCode
  {
    get { return _zipCode; }
    set { _zipCode = value; }
  }

  public Address(string state, string city, string street, string zipCode)
  {
    State = state;
    City = city;
    Street = street;
    ZipCode = zipCode;
  }

  public override string ToString()
  {
    return $"{_street}, {_city}, {_state} {_zipCode}";
  }
}
