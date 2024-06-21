using System;
using System.IO;


public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter writer = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    if (File.Exists(file))
    {
      _entries.Clear();
      using (StreamReader reader = new StreamReader(file))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          string[] parts = line.Split(",");

          Entry entry = new Entry
          {

            _date = parts[0],
            _promptText = parts[1],
            _entryText = parts[2],

          };
          _entries.Add(entry);
        }
      }
    }

    else
    {
      Console.WriteLine("File not found.");
    }
  }
}