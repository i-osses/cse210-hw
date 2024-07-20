using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Create some comments
        Comment comment1 = new Comment("John", "I love the message of this video!");
        Comment comment2 = new Comment("Emma", "Very inspiring talk.");
        Comment comment3 = new Comment("Michael", "Great insights on faith.");

        Comment comment4 = new Comment("Sarah", "The music is so uplifting.");
        Comment comment5 = new Comment("David", "Wonderful testimony.");
        Comment comment6 = new Comment("Rachel", "This video helped me understand the gospel better.");

        // Create some videos
        Video video1 = new Video("General Conference April 2024", "The Church of Jesus Christ of Latter-day Saints", 5400);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Come, Follow Me - The Book of Mormon", "The Church of Jesus Christ of Latter-day Saints", 3600);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        // Add videos to the video List
        List<Video> videos = new List<Video> { video1, video2 };

        // Iterate with foreach and then display the information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}