using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        // Create videos
        Video video1 = new Video("How to run fast", "McFarland", 300);
        Video video2 = new Video("Clashing of clash", "Zoolander Man", 240);
        Video video3 = new Video("Airplanes", "Cool Man", 180);

        // Add comments to videos
        video1.AddComment("Johnny", "Great video!");
        video1.AddComment("Free Guy", "wish he made more videos like this.");
        video1.AddComment("Darle", "Supper, cool! I learned a lot.");
        video1.AddComment("Josh", "The video could us some work, I didn't like it at all.");
        video1.AddComment("May", "Could be better.");

        video2.AddComment("June", "Interesting content!");
        video2.AddComment("May", "First Comment");
        video2.AddComment("Rey", "Could not be better.");
        video2.AddComment("Josh", "Super Dope can you make more like this.");

        video3.AddComment("Hennery", "Short and sweet, and i love the videos you make!!!!");
        video3.AddComment("Josh", "I wish it was shorter.");
        video3.AddComment("May", "Could be way better.");
        video3.AddComment("Darle", "didn't think i would like it, but I learned a lot.");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display all comments for the video
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment._commenter}: {comment._text}");
            }
            // Display a blank space for readabilty
            Console.WriteLine();
        }
    }
}