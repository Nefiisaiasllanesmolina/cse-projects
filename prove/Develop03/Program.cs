using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Jacob", 2, 18);
        reference.GetDisplayText();

        Word word = new Word("hola_");
        word.Hide();
        word.IsHidden();
    }
}