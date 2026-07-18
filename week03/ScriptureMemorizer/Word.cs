public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if(_isHidden == true)
        {
            string underscore = "";
            foreach (char c in _text)
            {
                underscore += "_";
            }
            return underscore;
        }

        else
        {
            return _text;
        }
    }
}