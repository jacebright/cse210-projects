// This class will load a txt file with scriptures able to be memorized. Methods
// will allow user to randomly select a scripture. Each part of the scripture
// (book, chapter, etc) will be separated by the "|" character to ensure no
// splicing issues
using System.IO;

public class Library
{
    private List<Scripture> _scriptures = [];
    private string _fileName;
    public Library(string fileName)
    {
        _fileName = fileName;
        // var txtPath = _fileName;

        using(var reader = new StreamReader(_fileName))
        {
            string firstLine = reader.ReadLine();
            while(reader.EndOfStream == false)
            {              
                var content = reader.ReadLine();
                var line = content.Split("|").ToList();

                string book = line[0];
                int chapter = Int32.Parse(line[1]);
                int startVerse = Int32.Parse(line[2]);

                if (line.Count() == 4)
                {
                    string text = line[3];
                    Reference reference = new Reference(book, chapter, startVerse);
                    Scripture scripture = new Scripture(reference, text);

                    _scriptures.Add(scripture);

                }
                else
                {
                    int endVerse = Int32.Parse(line[3]);
                    string text = line[4];
                    Reference reference = new Reference(book, chapter, startVerse, endVerse);
                    Scripture scripture = new Scripture(reference, text);

                    _scriptures.Add(scripture);
                }
            }
        }
    }
    public Scripture GetScripture()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0,_scriptures.Count);

        return _scriptures[index];
    }
}