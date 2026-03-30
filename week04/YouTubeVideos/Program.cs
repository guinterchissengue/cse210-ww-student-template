using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // First video
        Video video1 = new Video("Understanding C# Junior Class", "Cleidy Laura", 420);
        video1.AddComment(new Comment("Igal", "Great explanation!"));
        video1.AddComment(new Comment("Orlando", "Loved the examples."));
        video1.AddComment(new Comment("Siro", "Very clear and concise."));
        videos.Add(video1);

        // Second video
        Video video2 = new Video("Mastering Python from zero to hero", "Gil Carmona", 600);
        video2.AddComment(new Comment("Gerson", "This helped me a lot!"));
        video2.AddComment(new Comment("Leandro", "Fantastic content."));
        video2.AddComment(new Comment("Ivan", "Thank you for sharing!"));
        videos.Add(video2);

        // Third video
        Video video3 = new Video("Intro to JavaScript Junior Student Class", "Ismael Grahms", 300);
        video3.AddComment(new Comment("Pedro", "Super useful."));
        video3.AddComment(new Comment("Carlos", "Clear explanations."));
        video3.AddComment(new Comment("Helder", "I learned a lot!"));
        videos.Add(video3);

        // Display info for all videos
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}
