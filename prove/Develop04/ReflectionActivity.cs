class ReflectionActivity : Activity {
    
    public ReflectionActivity() 
    {
        gameDuration = 30000;
        activityName = "Reflection Activity";
        activityDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private readonly List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void Play()
    {
        // Use base class method
        ActivityInfo();
        gameDuration = GetDuration() * 1000;

        Console.Clear();

        LoadingAnimation("Get Ready...");

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n-- {RandomPrompt(prompts)} --");
        Console.WriteLine("\nThink about your response for a moment, then press [Enter] to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        CountdownTimer("You may begin in: ");
        Console.Clear();

        int elapsed = 0;
        while (elapsed < gameDuration) {
            LoadingAnimation($"> {RandomPrompt(questions)}", 15000);
            elapsed += 15000;
        }
        
        EndingMsg();
    }
}