using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates at least one event of each type and sets all of their values.
        // Creating the addressess
        Address receptionAddress = new Address("1234 Somewhere st", "Donde", "TX");
        Address lectureAddress = new Address("5678 There rd", "Here", "AZ");
        Address outdoorAddress = new Address("89 Nowhere blvd", "Everywhere", "CA");

        // Create the events
        ReceptionEvent reception = new ReceptionEvent("Bernie's Wedding Reception", 
        "Bernie and Grace just got married! Please join us for the reception", 
        "25 July 2024", "7:00 PM", receptionAddress, "someone@marriage.com");
        LectureEvent lecture = new LectureEvent("The Doctor speaks",
        "Come hear the Doctor speak! Hear about the latest alien news, bigger on the inside topics, and more!",
        "22 April 2011", "5:02 PM", lectureAddress, "The Doctor", 502);
        OutdoorEvent outdoor = new OutdoorEvent("Just Some Camping",
        "This is literally just a bunch of guys going to camp in the woods",
        "7 June 2024", "7:00 PM", outdoorAddress, "Mostly sunny. 1% chance of rain");
        List<Event> events = [reception, lecture, outdoor];
        
        // Iterate through the events and display the details
        foreach (Event activity in events)
        {
            Console.WriteLine("\nFull Details:\n");
            Console.WriteLine(activity.FullDetails());
            Console.WriteLine("\nStandard Details:\n");
            Console.WriteLine(activity.StandardDetails());
            Console.WriteLine("\nShort Description:\n");
            Console.WriteLine(activity.ShortDescription());
        }
    }
}