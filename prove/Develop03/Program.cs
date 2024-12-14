using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scriptures = new Scripture();
        scriptures.Scriptures();

        Reference reference = new Reference("Nefi", 2, 25);
        Console.WriteLine(reference.GetDisplayText());
    }
}