using System;

//3 instances of the video class

internal class Program
{
    private static void Main(string[] args)
    {
        
        //clear console window
        Console.Clear();

        Video video1 = new Video("Learning C#", "Rebeca", 120);
        //3 comments for video1
        Comment comment1 = new Comment("Laura", "Great video!");
        Comment comment2 = new Comment("Maria", "I learned a lot from this video.");
        Comment comment3 = new Comment("Rose", "Can't wait for the next video!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Learning Java", "Rosana", 90);
        //3 comments for video2
        Comment comment4 = new Comment("John", "Nice video!");
        Comment comment5 = new Comment("Sarah", "Very informative!");
        Comment comment6 = new Comment("Michael", "I enjoyed watching this!");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Learning JS", "Gabriel", 150);//
                                                                //3 comments for video
        Comment comment7 = new Comment("Alex", "Great video!");
        Comment comment8 = new Comment("Daniel", "I learned a lot from this video.");
        Comment comment9 = new Comment("Natalia", "Can't wait for the next video!");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        //place the video in a list
        List<Video> videos = new();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //display the videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("\n");
        }
    }
}