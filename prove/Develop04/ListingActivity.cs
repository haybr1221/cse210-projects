class ListingActivity : Activity {
    public ListingActivity()
    {
        gameDuration = 30000;
        activityName = "Listing Activity";
        activityDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private readonly List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public override void Play() {
        // Use base class method
        ActivityInfo();
        gameDuration = GetDuration() * 1000;

        Console.Clear();

        LoadingAnimation("Get Ready...");

        Console.WriteLine($"List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n-- {RandomPrompt(prompts)} --");
        CountdownTimer("You may begin in: ");
        Console.WriteLine();
        
        int answers = 0;
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromMilliseconds(gameDuration);
        DateTime endTime = startTime + duration;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            answers++;
        }

        Console.WriteLine($"You listed {answers} items!");

        EndingMsg();

    }
}