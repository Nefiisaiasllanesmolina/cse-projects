using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Reference("Jacob", 2, 18), "Pero antes de buscar riquezas, buscad el reino de Dios");
        library.AddScripture(new Reference("2 Nefi", 2, 25, 26), "Adán cayó para que los hombres existiesen; y existen los hombres para que tengan gozo. Y el Mesías vendrá en la plenitud de los tiempos, a fin de redimir a los hijos de los hombres de la caída. Y porque son redimidos de la caída, han llegado a quedar libres para siempre, discerniendo el bien del mal, para actuar por sí mismos, y no para que se actúe sobre ellos, a menos que sea por el castigo del la ley en el grande y último día, según los mandamientos que Dios ha dado.");

        while (true)
        {
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandomWords();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("Good job. You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures :).");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}