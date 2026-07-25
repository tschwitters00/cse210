public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    private int _numberOfComments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    private void GetNumberOfComments(List<Comment> comments)
    {
        _numberOfComments = 0;
        foreach(Comment comment in comments)
        {
            _numberOfComments += 1;
        }
    }

    public List<string> GetDisplayText()
    {
        GetNumberOfComments(_comments);
        string numberOfComments = _numberOfComments.ToString();
        string length = _length.ToString();
        List<string> list = [_title, _author, length, numberOfComments];

        foreach(Comment comment in _comments)
        {
            List<string> commentParts = comment.GetDisplayText();
            string name = commentParts[0];
            string commentContent = commentParts[1];
            list.Add(name);
            list.Add(commentContent);
        }
        
        return list;
    }
}