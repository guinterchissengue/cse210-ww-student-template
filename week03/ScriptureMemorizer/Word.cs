public class Word
{
    private string _text;
    private bool _isHidden;

    // Word constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); 
        }
        else
        {
            return _text;
        }
    }
}