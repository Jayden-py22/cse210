using System;
using System.Collections.Generic;

namespace AbstractionWithYouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of videos
            List<Video> videos = new List<Video>();

            // Video 1
            Video video1 = new Video("C# Basics", "John Doe", 300);
            video1.AddComment(new Comment("Alice", "Great video!"));
            video1.AddComment(new Comment("Bob", "Very informative."));
            video1.AddComment(new Comment("Charlie", "Loved the examples."));
            videos.Add(video1);

            // Video 2
            Video video2 = new Video("OOP Concepts", "Jane Smith", 450);
            video2.AddComment(new Comment("Dave", "Clear explanation."));
            video2.AddComment(new Comment("Eve", "Helped me understand inheritance."));
            video2.AddComment(new Comment("Frank", "Thanks for sharing."));
            videos.Add(video2);

            // Video 3
            Video video3 = new Video("Advanced C#", "Mike Brown", 600);
            video3.AddComment(new Comment("Grace", "Excellent content!"));
            video3.AddComment(new Comment("Heidi", "Well structured."));
            video3.AddComment(new Comment("Ivan", "Looking forward to more videos."));
            videos.Add(video3);

            // Display video information
            foreach (var video in videos)
            {
                Console.WriteLine(video.DisplayInfo());
                Console.WriteLine("------------");
            }
        }
    }
}