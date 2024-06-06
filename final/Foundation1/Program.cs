using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Video v1 = new Video("Introducing South Korea", "Lonely Planet", 145);
        Comment v1c1 = new Comment("Meela", "I love Korean history.");
        Comment v1c2 = new Comment("Daniel", "I'm glad you're showing the beauty of my country.");
        Comment v1c3 = new Comment("Vinn", "Wonderful! I wish to visit there someday!");
        v1.ListComment(v1c1);
        v1.ListComment(v1c2);
        v1.ListComment(v1c3);
        videoList.Add(v1);
        Video v2 = new Video("Seoul, South Korea: Exploring Korean Culture in Seoul", "Mickela Mallozzi", 380);
        Comment v2c1 = new Comment("Jae", "Always fun to see an outside perspective.");
        Comment v2c2 = new Comment("Nara", "Sometimes I miss home, this video helped me today.");
        Comment v2c3 = new Comment("June", "Thank you for the video, as I'm always curious about other cultures.");
        v2.ListComment(v2c1);
        v2.ListComment(v2c2);
        v2.ListComment(v2c3);
        videoList.Add(v2);
        Video v3 = new Video("11 Awesome Things To Do in Seoul, South Korea", "Eileen Aldis", 738);
        Comment v3c1 = new Comment("Cho", "I've been to that park a few times.");
        Comment v3c2 = new Comment("Hana", "For the next video, try more traditional events.");
        Comment v3c3 = new Comment("Kevin", "Great for my trip in the fall!");
        v3.ListComment(v3c1);
        v3.ListComment(v3c2);
        v3.ListComment(v3c3);
        videoList.Add(v3);
        foreach (Video video in videoList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}