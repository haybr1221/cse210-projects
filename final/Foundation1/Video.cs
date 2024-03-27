class Video
{
    private string _title;

    private string _author;

    private int _length;

    public Video(string title, string author, int length) 
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public List<Comment> _comments = new List<Comment>{};

    public void Display()
    {
        int mins = _length / 60;
        int seconds = _length % 60;

        Console.WriteLine($"\n{_title} ({mins}:{seconds:D2}) by {_author}");

        int comments = NumComments();
        Console.WriteLine($"There are {comments} comments:");
        foreach(Comment c in _comments)
        {
            c.Display();
        }
    }

    public int NumComments()
    {
        int num = 0;
        foreach(Comment c in _comments)
        {
            num++;
        }
        return num;
    }

}