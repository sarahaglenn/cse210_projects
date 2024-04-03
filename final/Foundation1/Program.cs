using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = [];
        Video catVideo = new Video("Baby Kittens", "Sam Jenkins", 95);
        Video gardenVideo = new Video("How to Start a Garden", "Andrew Anderson", 545);
        Video runningVideo = new Video("Get a PR in your next 10K!", "Kara Goucher", 358);
        Video funnyVideo = new Video("Top 5 funniest moments from The Office", "OfficeFanatic01", 176);
        videos.Add(catVideo);
        videos.Add(gardenVideo);
        videos.Add(runningVideo);
        videos.Add(funnyVideo);

        catVideo.AddComment(new Comment("Slim Jim", "These kittens are so cute!"));
        catVideo.AddComment(new Comment("Brandi Yi", "The gray one looks like a cat I had as a kid"));
        catVideo.AddComment(new Comment("Wesley Austin", "How did you end up with so many kittens?"));

        gardenVideo.AddComment(new Comment("Bella Meza", "How do I figure out when I can start planting for where I live? I don't want my plants to die from a late freeze!"));
        gardenVideo.AddComment(new Comment("Addilyn Reeves", "Where did you get that awesome shovel? Mine broke last season and I need to replace it."));
        gardenVideo.AddComment(new Comment("Andrew Anderson", "I found it at Home Depot. It is seriously the best for these type of gardening projects. Only $20!"));
        gardenVideo.AddComment(new Comment("Landry McClure", "Really great video, Andrew! Thanks for all the helpful information. I'm excited to finally start a garden this year."));

        runningVideo.AddComment(new Comment("Shay Hurst", "You are so amazing! I loved following your career and I'm so glad now you've turned to coaching. Thanks for the tips!"));
        runningVideo.AddComment(new Comment("Samir Thomas", "This is such great information. I have a 10K coming up next month, and I'm totally going to use this info. I never really thought about my fueling before."));
        runningVideo.AddComment(new Comment("Athena Tapia", "How much recovery time would you suggest afterword? And should I be doing zone 1 running during that time or no running at all?"));
        runningVideo.AddComment(new Comment("Quinton Brooks", "This completely explains why I kept hitting a wall in my races before! Ahhh I'm going to go sign up for another race right now!"));

        funnyVideo.AddComment(new Comment("Brayan Wood", "HAHAHA these are the best!"));
        funnyVideo.AddComment(new Comment("Kara Richard", "Hahaha the stapler in the jello gets me every time. The commitment!"));
        funnyVideo.AddComment(new Comment("Sawyer Ross", "This is the most classic show. Nothing will ever be funnier to me. #TheOfficeForever"));
    
        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetFullDetailString());
        }
    }
}