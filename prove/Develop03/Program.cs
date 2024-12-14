using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scriptures = new Scripture();

        Reference reference = new Reference("Nefi", 2, 25);
        reference.GetDisplayText();
    }
}