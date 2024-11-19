
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {   
        DateTime today = DateTime.Today;
        _date = today.ToString("d");
        

        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}