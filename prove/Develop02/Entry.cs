public class Entry {

    public string dateText;

    public string _prompt; 

    public string _date;

    public string GivePrompt() {
        PromptGenerator promptGenerator = new PromptGenerator();
        return promptGenerator.GetPrompt();
    }


    public string GetDate() {
        DateTime theCurrentTime = DateTime.Now;
        return dateText = theCurrentTime.ToShortDateString();
    }

    public string Display() {
        _prompt = GivePrompt();
        _date = GetDate();
        return $"Date: {_date} - Prompt: {_prompt}";
    }
}
