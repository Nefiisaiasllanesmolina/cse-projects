public class Reference{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public string References(){
        string _reference = _book + _chapter + ":" + _verse + "-" + _endVerse;
        return _reference;
    }
}