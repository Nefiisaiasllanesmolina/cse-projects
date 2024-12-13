public class Scripture{

    public string Reference(){



        List<string> _references = new List<string>
        {
            "Jacob 2:18 Pero antes de buscar riquezas, buscad el reino de Dios.",
            "2 Nefi 2:25 Adán cayó para que los hombres existiesen; y existen los hombres para que tengan gozo.",
        };

        Random rnd = new Random();
        int index = rnd.Next(_references.Count);
        string _scripture = _references[index];
        Console.WriteLine(_scripture); //Este podría ponerlo en Program para imprimir, pero de acuerdo al principio de encapsulation debe estar aquí
        return _scripture;
    }

    
}