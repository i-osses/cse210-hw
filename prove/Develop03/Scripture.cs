using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Reference Reference
  {
    get { return _reference; }
    set { _reference = value; }
  }
  public List<Word> Words
  {
    get { return _words; }
    set { _words = value; }
  }

  public Scripture(Reference reference, string text)
  {
    Reference = reference;
    Words = text.Split(' ').Select(word => new Word(word)).ToList(); //*
  }

  public void HideRandomWords(int numberToHide)
  {
    Random rand = new Random();
    int hiddenCount = 0;
    while (hiddenCount < numberToHide && Words.Any(word => !word.IsHidden()))
    {
      int index = rand.Next(Words.Count);
      if (!Words[index].IsHidden())
      {
        Words[index].Hide();
        hiddenCount++;
      }
    }
  }
  public string GetDisplayText()
  {
    return string.Join(" ", Words.Select(word => word.GetDisplayText()));
  }

  public bool IsCompletelyHidden()
  {
    return Words.All(word => word.IsHidden());
  }
}