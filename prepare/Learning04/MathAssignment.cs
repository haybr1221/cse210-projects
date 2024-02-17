public class MathAssignment : Assignment {
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string _studentName, string _topic, string textbook, string problems) : base(_studentName, _topic) {
        this._textbookSection = textbook;
        this._problems = problems;
    }
    public string GetHomeworkList() {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}