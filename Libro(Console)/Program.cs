using Libro;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro.Libro lib = new Libro.Libro();

        lib[0] = "pagina 1";
        lib[1] = "pagina 2";
        lib[2] = "pagina 3";
        lib[7] = "pagina 4";


        

        Console.WriteLine($"{lib[7]}");
    }
}