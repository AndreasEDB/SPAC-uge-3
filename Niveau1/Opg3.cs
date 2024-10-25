using System.Globalization;

namespace Niveau1;

public class Opg3
{
    private float float1 = new();
    private float float2 = new();

    private void GetNumbers()
    {
        Console.Write("Indtast det første tal: ");
        while (!float.TryParse(Console.ReadLine()?.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out float1))
        {
            Console.WriteLine("Ugyldigt input. Prøv igen.");
            Console.Write("Indtast det første tal: ");
        }

        Console.Write("Indtast det andet tal: ");
        while (!float.TryParse(Console.ReadLine()?.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out float2))
        {
            Console.WriteLine("Ugyldigt input. Prøv igen.");
            Console.Write("Indtast det andet tal: ");
        }
    }

    private float AddNumbers(float num1, float num2)
    {
        return num1 + num2;
    }

    public void DoMath()
    {
        GetNumbers();

        float sum = AddNumbers(float1, float2);

        Console.WriteLine($"Summen af {float1} og {float2} er {sum}!");
    }
}
