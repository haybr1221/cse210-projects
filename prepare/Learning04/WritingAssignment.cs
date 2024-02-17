public class WritingAssignment : Assignment {
    private string _title;

    public WritingAssignment(string _studentName, string _topic, string title) : base(_studentName, _topic) {
        this._title = title;
    }
    public string GetWritingInfo() {
        return $"{_title} by {_studentName}";
    }
}
