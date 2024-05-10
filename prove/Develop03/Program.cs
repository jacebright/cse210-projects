using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the txt file with a library of scriptures to memorize a random
        // scripture
        string scriptureLibrary = @"C:\Users\jaceb\OneDrive\Desktop\Software Development\C#\CSE210\cse210-projects\prove\Develop03\scriptures.txt";
        Library library = new Library(scriptureLibrary);
        Scripture scripture = library.GetScripture();

        int count = 0;
        while (scripture.IsCompletelyHidden() is false)
        {
            // Hide words if this is not the first time through the loop
            if (count != 0)
            {
                scripture.HideRandomWords(3);
            }
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPlease enter to continue or type 'quit' to finish:");
            string onward = Console.ReadLine();
            
            // Check if the user desires to quit
            if (onward == "quit")
            {
                break;
            }
            count++;
        }
    }
}