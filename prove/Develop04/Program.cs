// Creativity Shown:
// Functionality added to not repeat the same question or prompt in a single session
// Counting functionality to report how many times the user completed each activity
// during their session


using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Description list to store the descripions for each activity
        List<string> descriptions = [
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        ];
        
        List<string> menuOptions = [
            "1. Start Breathing Activity",
            "2. Start Reflection Activity",
            "3. Start Listing Activity",
            "4. Quit"
        ];

        // Count variables to track how many times the user has done each activity
        int breathe = 0;
        int reflect = 0;
        int list = 0;


        string choice = "0";

        // Begin activity loop
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            foreach(string menuOption in menuOptions)
            {
                Console.WriteLine($"\t{menuOption}");
            }
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", descriptions[0]);
                breathing.Run();
                breathe += 1;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity("Reflection Activity", descriptions[1]);
                reflection.Run();
                reflect += 1;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity("Listing Activity", descriptions[2]);
                listing.Run();
                list += 1;
            }

        int total = breathe + list + reflect;
        Console.WriteLine($"Thank you for being mindful today. You completed {total} activities:\nBreathing: {breathe}\nReflecting: {reflect}\nListing: {list}");
        }


        
    }
}