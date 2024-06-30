public class Word
{
  private string _text;
  private bool _isHidden;

  public string Text
  {
    get { return _text; }
    set { _text = value; }
  }
  // acces by method
  /* 
  public bool IsHidden
  {
    get { return _isHidden; }
    set { _isHidden = value; } 
    
    }*/


  public Word(string text)
  {
    Text = text;
    _isHidden = false;
  }

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    if (_isHidden)
    {
      return new string('_', Text.Length);
    }
    else
    {
      return Text;
    }
  }
}