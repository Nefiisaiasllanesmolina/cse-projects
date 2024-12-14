public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {  
        string wordHidden = "";
        for (int i=0; i<_text.Length; i++)
        {
            wordHidden = wordHidden + "_";
        }
        Console.Write(wordHidden);
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        if (_text.Contains("_"))
        {
            _isHidden = true;
        }
        Console.Write(_isHidden);
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if ()
        {

        }
        return "hola";
    }
}