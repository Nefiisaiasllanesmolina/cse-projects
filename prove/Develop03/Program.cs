using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Jacob", 2, 18);
        reference.GetDisplayText();

        Word word = new Word("Porque me pasa");
        word.Hide();
        word.IsHidden();
    }
}