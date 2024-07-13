using System;

public class Shape
{
  private string _color;

  public string Color
  {
    get { return _color; }
    set { _color = value; }

  }

  public Shape(string color)
  {
    Color = color;
  }

  public string GetColor()
  {
    return _color;
  }


  public virtual double GetArea()
  {
    int area = 0;
    return area;
  }


}
