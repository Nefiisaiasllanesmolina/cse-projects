public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {  
        string hola = "hola";
        string wordHidden = "";
        for (int i=0; i<hola.Length; i++){
            wordHidden = wordHidden + "_";
        }
        Console.WriteLine(wordHidden);
    }

    public void Show()
    {

    }

    /*public bool IsHidden()
    {

    }

    public string GetDisplayText()
    {

    }*/
}