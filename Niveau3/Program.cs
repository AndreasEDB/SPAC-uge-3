namespace Niveau3;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Opgave 1\n");
        Opg1 opg1 = new();
        opg1.ReadNames();
        opg1.SortNames();
        opg1.PrintNames();
        Console.WriteLine("");
        Console.WriteLine("");

        // Console.WriteLine("Opgave 2\n");
        // Opg2 opg2 = new();
        // opg2.CreatePerson();
        // Console.WriteLine("");
        // Console.WriteLine("");

        // System.Console.WriteLine("Opgave3\n");
        // Opg3 opg3 = new();
        // opg3.GetNumber();
        // System.Console.WriteLine("");
        // System.Console.WriteLine("");
    }
}