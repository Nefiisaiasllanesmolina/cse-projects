
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display(string _promptText, string _entryText)
    {   
        DateTime today = DateTime.Today;
        _date = today.ToString("d");
        
        string cap = ($"Date: {_date} - Prompt: {_promptText} \n{_entryText}");
        //Console.WriteLine($"{_entryText}");
        return cap;
    }
}