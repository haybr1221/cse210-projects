class BreathingActivty : Activity {

    public BreathingActivty() 
    {
        gameDuration = 30000; // better way to define it?
        activityName = "Breathing Activity";
        activityDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Play()
    {
        // Use base class method
        ActivityInfo();
        gameDuration = GetDuration() * 1000;

        Console.Clear();
        LoadingAnimation("Get ready...");

        int elapsed = 0;
        while (elapsed < gameDuration) {
            Console.WriteLine();
            CountdownTimer("Breathe in...", 3000);
            Console.WriteLine();
            CountdownTimer("Breathe out...", 5000);
            elapsed += 8000;
            Console.WriteLine();
        }
        
        EndingMsg();
    }
}