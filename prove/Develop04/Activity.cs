abstract class Activity {

    // The set game duration
    protected int gameDuration;

    // Activity name
    protected string activityName;

    // Activity description
    protected string activityDesc;

    // Abstract method
    public abstract void Play();

    // Display loading animation
    protected virtual void LoadingAnimation(string message = "Loading", int duration = 5000) {
        Console.WriteLine(message);
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase prev character
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase prev character
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase prev character
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase prev character
            elapsed += 1500;
        }
    }

    // Display CountdownTimer
    protected static void CountdownTimer(string message = "Get ready", int duration = 5000)
    {
        int timeRemaining = duration / 1000; // Convert milliseconds to seconds
        Console.Write($"{message}");
        while (timeRemaining > 0)
        {   
            Console.Write(timeRemaining);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timeRemaining--;
        }
    }

    // Display info for activity
    protected void ActivityInfo() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}");
        Console.WriteLine();
        Console.WriteLine(activityDesc);
    }

    // Display ending msg for activity
    protected void EndingMsg() {
        LoadingAnimation("\nWell done!!");
        LoadingAnimation($"\nYou completed {gameDuration/1000} seconds of the {activityName}.");
    }

    // Select a random index to use
    protected string RandomPrompt(List<string> list) {
        Random random = new Random();
        int i = random.Next(list.Count);
        return list[i];
    }

    // Get game duration
    protected int GetDuration() {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        return int.Parse(Console.ReadLine());
    }
}
