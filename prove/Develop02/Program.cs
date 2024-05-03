// This program resolves a difficulty in journaling where one does not know what
// to write. This is resolved by giving a prompt to write about and then saving
// the journal entry to a csv file.

// ***The extra creativity and functionality occurs in the Journal.cs file,
// adding csv compatability which loads journal entries from csv files able to be
// opened in excel.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string choice;
        // Create a new journal object to be called throughout
        Journal journal = new Journal();
        journal._entries = [];
        do
        {

            Console.Write("Please selct one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            choice = Console.ReadLine();

        if (choice == "1")
        {
            PromptGenerator generator = new PromptGenerator();
            Entry entry = new Entry();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            entry._date = dateText;
            entry._promptText = generator.GetRandomPrompt();
            Console.WriteLine(entry._promptText);
            Console.Write(">");
            entry._entryText = Console.ReadLine();
            journal.AddEntry(entry);
        }
        else if (choice == "2")
        {
            journal.DisplayAll();
        }
        else if (choice == "3")
        {
            Console.Write("What is the csv filename? ");
            journal.LoadFile(Console.ReadLine());

        }
        else if (choice == "4")
        {
            Console.Write("What is the filename? ");
            journal.SaveToFile(Console.ReadLine());
        }
        } while (choice != "5");
    }

   
}