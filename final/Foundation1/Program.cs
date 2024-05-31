using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of each video and add it to the list
        Video video1 = new Video("How to write code", "Joe Dev", 123);
        Video video2 = new Video("How to apply for a job", "Barney Fife", 1224);
        Video video3 = new Video("How to advance from the mailroom", "Mr Twimble", 25);

        List<Video> videos = [video1, video2, video3];

        // Comments for video 1
        List<string> comVideo1 = ["Hello World", "Functions, classes, projects",
            "Space invaders Clone", "Already hooked!"];
        List<string> commentersVideo1 = ["Ron Weasley", "Dumbledore", "Hermione Granger", "Harry Potter"];

        // Comments for Video 2
        List<string> comVideo2 = ["Resumes, for sure", "First comment", "First Comment"];
        List<string> commentersVideo2 = ["Bob's Bugs Be Gone", "Shirley Temple", "Clark Kent", "Lex Luther"];

        // Comments for Video 3
        List<string> comVideo3 = ["How to sit down at a desk", "How to dictate memorandums",
                "How to develop executive style", "How to commute in a three button suit"];
        List<string> commentersVideo3 = ["Mr Bigley", "Bart Frump", "Rosemary Pinkington", "Hedy Larue"];

        // Write a function to create comment objects given the video, the comment, and the commenter
        static void CreateComments(Video video, List<string> comments, List<string> commenters)
        {
            foreach (string comment in comments)
        {
            // Create a new comment object for each comment in the list, finding
            // the coordinating comment via findIndex
            Comment newComment = new Comment(comment, commenters[comments.FindIndex(a => a.Contains(comment))]);
            // Add the comment to the appropriate video
            video.AddComment(newComment);
        }
        }

        // Create the comments for each video
        CreateComments(video1, comVideo1, commentersVideo1);
        CreateComments(video2, comVideo2, commentersVideo2);
        CreateComments(video3, comVideo3, commentersVideo3);

        // Display the info for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}