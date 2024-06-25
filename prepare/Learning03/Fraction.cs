using System.Runtime.InteropServices;

public class Fraction
{
  private int _top;
  private int _bottom;

  // constructors
  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  // Getters and Setters
  /* 
    public int GetTop()
    {
      return _top;
    }

    public void SetTop(int top)
    {
      _top = top;
    }

    public int GetBottom()
    {
      return _bottom;
    }

    public void SetBottom(int bottom)
    {
      _bottom = bottom;
    } */

  public int Top
  {
    get { return _top; }
    set { _top = value; }
  }

  public int Bottom
  {
    get { return _bottom; }
    set { _bottom = value; }
  }

  // Functions

  public string GetFractionString()
  {
    string fractionText = $"{Top}/{Bottom}";
    return fractionText;
  }

  public double GetDecimalValue()
  {
    double value = _top / _bottom;
    return value;
  }



}