public class Assignment {
    protected string _studentName;

    protected string _topic;

    public Assignment(string name, string topic) {
        this._studentName = name;
        this._topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }
}