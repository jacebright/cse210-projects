using System.IO;

public class Journal
{
    public List<Entry> _entries;

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    public void LoadFile(string file)
    {
        var csvPath = @file;
        using(var reader = new StreamReader(csvPath))
        {
            while(reader.EndOfStream == false)
            {
                var content = reader.ReadLine();
                var line = content.Split(",").ToList();

                Entry entry = new Entry();
                entry._date = line[0];
                entry._promptText = line[1];
                entry._entryText = line[2];

                _entries.Add(entry);
            }
        }
        // string[] lines = System.IO.File.ReadAllLines(file);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");
        //     Entry entry = new Entry();
        //     entry._date = parts[0];
        //     entry._promptText = parts[1];
        //     entry._entryText = parts[2];

        //     _entries.Add(entry);
        
    }
}