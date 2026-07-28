using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Copines", "Aya Nakamura", 177 
        );

        video1.AddComment(new Comment("Amirahy", "She is African, she speaks french, she has a japanese name, she has fans all over the world"));
        video1.AddComment(new Comment("Peter", "Fun fact: U came here cuz this song is everywhere.Don’t lie "));
        video1.AddComment(new Comment("Anura", "1 minute of silence for them who didn't find this masterpiece"));
        video1.AddComment(new Comment("General", "Tiktok don't ruin songs, it helps artists to be discovered."));
        video1.AddComment(new Comment("Avery", "here from tiktok. not disappointed. she’s beautiful and great song."));

        videos.Add(video1);

        Video video2 = new Video(
            "Dai Dai", "Shakira and Burna Boy", 240 
        );

        video2.AddComment(new Comment("Ahmed", "when i was 7 shakira was 22, now I'm 22 and shakira is 22."));
        video2.AddComment(new Comment("Angocurioso", "This girl was born to make music for world cup"));
        video2.AddComment(new Comment("JHPII", "So basically, Maria Carey owns Christmas and Shakira owns every World Cup."));
        video2.AddComment(new Comment("Deborah", "Future billionaires liked this comment😂"));
        video2.AddComment(new Comment("Jadier", "The best song of the 2026 World Cup"));

        videos.Add(video2);


        Video video3 = new Video(
            "Enjoy", "Jux and Diamond Platnumz", 221 
        );

        video3.AddComment(new Comment("Roselyn", "Who is here because of Priscilla 😂❤❤❤❤🎉🎉🎉🎉🎉🎉🎉"));
        video3.AddComment(new Comment("Imran", "I swear this song will make me spend all all invested"));
        video3.AddComment(new Comment("Abdirah", "Thanks bro that is why always I love mam"));
        video3.AddComment(new Comment("Cindy", "Who would have thought that pricillia will bring us here in 2025"));
        video3.AddComment(new Comment("Magdalene", "This song is the best"));

        videos.Add(video3);


        Video video4 = new Video(
            "Water", "Tyla", 219 
        );

        video4.AddComment(new Comment("Josh", "The next big superstar 🌟"));
        video4.AddComment(new Comment("Tumelo", "I love how her visuals are so clean, very different from other south African artists"));
        video4.AddComment(new Comment("Lisa", "SHE JUST WON A GRAMMY CONGRATSS QUEEN"));
        video4.AddComment(new Comment("Aderin", "Nobody will ever know why this comment got so much likes"));
        video4.AddComment(new Comment("Jennifer", "I love her voice. It's so calming and light. Love this"));

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Title   : {video.Title}");
            Console.WriteLine($"Author  : {video.Author}");
            Console.WriteLine($"Length  : {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}:");
                Console.WriteLine($"    {comment.Text}");
                Console.WriteLine();
            }
        }

        Console.WriteLine("------------------------------------------");
         
         
    }
}