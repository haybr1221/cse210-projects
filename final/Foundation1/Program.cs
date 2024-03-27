using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>{};
        Console.Clear();

        // Create a new video
        Video v1 = new Video("Ranking Pokemon Types", "TheGreatestTrainer", 70);
        // Add it to the list of videos
        _videos.Add(v1);
            // Add comments and add them to the video's comment list
            Comment v1c1 = new Comment("pkmnfan151", "Fairy is easily the worst type");
            v1._comments.Add(v1c1);
            Comment v1c2 = new Comment("theverybestlikenooneeverwas", "rock in s tier is crazy");
            v1._comments.Add(v1c2);
            Comment v1c3 = new Comment("charidon32", "I entered the giveaway");
            v1._comments.Add(v1c3);
            Comment v1c4 = new Comment("Ash Ketchum", "I caught them all!");
            v1._comments.Add(v1c4);
        
        // Create a new video
        Video v2 = new Video("Top 10 Greatest Archaeological Discoveries", "Professor Hershel Layton", 306);
        // Add it to the list of videos
        _videos.Add(v2);
            // Add comments and add them to the video's comment list
            Comment v2c1 = new Comment("Aaron Frost", "This is so cool!");
            v2._comments.Add(v2c1);
            Comment v2c2 = new Comment("Ryan Park", "I never knew about number 3... that's so strange");
            v2._comments.Add(v2c2);
            Comment v2c3 = new Comment("Violet Hidalgo", "I enjoy solving mysteries and rewriting history");
            v2._comments.Add(v2c3);
            Comment v2c4 = new Comment("Stella", "more videos like this please!");
            v2._comments.Add(v2c4);

        Video v3 = new Video("5 Seconds of Silence", "Moments to Cherish", 5);
        // Add it to the list of videos
        _videos.Add(v3);
            // Add comments and add them to the video's comment list
            Comment v3c1 = new Comment("John Smith", "I can't believe I wasted 5 seconds");
            v3._comments.Add(v3c1);
            Comment v3c2 = new Comment("Jane", "i can't hear anything?");
            v3._comments.Add(v3c2);
            Comment v3c3 = new Comment("Skye Doe", "Why would you post something like this");
            v3._comments.Add(v3c3);
            Comment v3c4 = new Comment("fancydolphin432", "I listen to this every morning");
            v3._comments.Add(v3c4);

        Video v4 = new Video("My thoughts on Apples Never Fall", "JustBeanBookish", 634);
        // Add it to the list of videos
        _videos.Add(v4);
            // Add comments and add them to the video's comment list
            Comment v4c1 = new Comment("shakeitoffff56", "this book sucks");
            v4._comments.Add(v4c1);
            Comment v4c2 = new Comment("Nephi", "my book is better");
            v4._comments.Add(v4c2);
            Comment v4c3 = new Comment("Calvin Johnson", "I also really liked it! 5 stars!");
            v4._comments.Add(v4c3);
            Comment v4c4 = new Comment("Tigger", "i did not understand this book");
            v4._comments.Add(v4c4);

        foreach (Video v in _videos)
        {
            v.Display();
        }
    }
}