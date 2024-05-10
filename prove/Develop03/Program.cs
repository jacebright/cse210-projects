// Creativity shown:
// Created a txt file with a variety of scriptures. Added a library class to read 
// the file and create a scripture object for each one, then the class uses a 
// method to randomly select a scripture for memorizing.
// Additionally I added code to only randomly hide words still showing instead
// of attempting to hide words already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the txt file with a library of scriptures to memorize a random
        // scripture
        Library library = new Library("scriptures.txt");
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