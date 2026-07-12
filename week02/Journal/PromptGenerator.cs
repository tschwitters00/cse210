using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int len = _prompts.Count;
        int randInt = rnd.Next(0, len);
        return _prompts [randInt];
    }
}