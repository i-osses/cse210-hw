public class Reference
{
  private string _book;
  private int _chapter;
  private int _verse;
  private int _endVerse;

  public string Book
  {
    get { return _book; }
    set { _book = value; }
  }

  public int Chapter
  {
    get { return _chapter; }
    set { _chapter = value; }
  }

  public int Verse
  {
    get { return _verse; }
    set { _verse = value; }
  }

  public int EndVerse
  {
    get { return _endVerse; }
    set { _endVerse = value; }
  }

  //Constructors 

  public Reference(string book, int chapter, int verse)
  {
    Book = book;
    Chapter = chapter;
    Verse = verse;
    EndVerse = verse;
  }

  public Reference(string book, int chapter, int verse, int endVerse) : this(book, chapter, verse)
  {
    EndVerse = endVerse;
  }

  public string GetDisplayText()
  {
    if (Verse == EndVerse)
    {
      return $"{Book} {Chapter}:{Verse}";
    }
    else
    {
      return $"{Book} {Chapter}:{Verse}-{EndVerse}";
    }
  }
}