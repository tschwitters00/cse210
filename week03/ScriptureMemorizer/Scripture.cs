public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        List<string> words = text.Split(' ').ToList();
        foreach (string i in words)
        {
            Word w = new Word(i);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for(int i = 0 ; i < numberToHide; i++)
        {   
            int index = -1;
            List<int> indexs = new List<int>();
            foreach(Word w in _words)
            {
                index += 1;
                if(w.isHidden() == false)
                {
                    indexs.Add(index);
                }
            }

            if(indexs.Count != 0)
            {
                int randIndex = random.Next(indexs.Count);
                _words[indexs[randIndex]].Hide();
            }
        }
        
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText();
        foreach(Word w in _words)
        {
            text += w.GetDisplayText() + " ";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        int notHid = 0;
        foreach(Word w in _words)
        {
            bool check = w.isHidden();
            if(check == false)
            {
               notHid = 1;
            }
        }

        if(notHid == 1)
        {
            return false;
        }
        
        else
        {
            return true;
        }
    }
}