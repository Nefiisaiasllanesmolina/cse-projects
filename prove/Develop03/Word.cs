public class Word{

    public string _text { get; }
    public bool _isHidden { get; private set; }

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }



    /*private string _text;
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

    public bool _isHidden()
    {
        if (_text.Contains("_"))
        {
            _isHidden = true;
        }
        Console.Write(_isHidden);
        return _isHidden;
    }

    /*public string GetDisplay_text()
    {
        
        return "hola";
    }*/
}