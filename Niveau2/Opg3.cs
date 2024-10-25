using System;

namespace Niveau2;

public class Opg3
{
    private int number = new();

    public void GetNumber()
    {
        System.Console.Write("Indtast et heltal: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ugyldigt input. Prøv igen.\n");
            Console.Write("Indtast et heltal: ");
        }

        System.Console.WriteLine($"Det indtastede tal er {number}");
    }
}
