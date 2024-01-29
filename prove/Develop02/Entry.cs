public class Entry {


    private string prompt; 

    private string date;

    public static string GivePrompt() {
        PromptGenerator promptGenerator = new PromptGenerator();
        return promptGenerator.GetPrompt();
    }


    public static string GetDate() {
        DateTime theCurrentTime = DateTime.Now;
        return theCurrentTime.ToShortDateString();
    }

    public string Display() {
        prompt = GivePrompt();
        date = GetDate();
        return $"Date: {date} - Prompt: {prompt}";
    }
}
