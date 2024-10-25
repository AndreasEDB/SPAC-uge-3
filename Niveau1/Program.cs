namespace Niveau1;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Opgave 1\n");
        Opg1 opg1 = new();
        opg1.PrintValues();
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Opgave 2\n");
        Opg2 opg2 = new();
        opg2.IsInputEven();
        Console.WriteLine("");
        opg2.ForLoop();
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Opgave 3\n");
        Opg3 opg3 = new();
        opg3.DoMath();
        Console.WriteLine("");
        Console.WriteLine("");
    }
}
