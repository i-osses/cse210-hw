public class MathAssignment : Assignment
{
  private string _textbookSecction;
  private string _problems;

  public MathAssignment(string studentName, string topic, string textbookSecction, string problems) : base(studentName, topic)
  {
    _textbookSecction = textbookSecction;
    _problems = problems;
  }

  public string GetHomeworkList()
  {
    return $"Section {_textbookSecction} Problems {_problems}";
  }
}