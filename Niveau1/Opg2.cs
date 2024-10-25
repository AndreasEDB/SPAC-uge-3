namespace Niveau1;

public class Opg2
{
    private int inputNumber = new();

    private void GetInput()
    {
        Console.Write("Indtast et heltal: ");
        inputNumber = Int32.Parse(Console.ReadLine() ?? "0");
    }

    public void IsInputEven()
    {
        GetInput();
        string isEven = inputNumber % 2 == 0 ? "lige" : "ulige";
        Console.WriteLine($"{inputNumber} er {isEven}");
    }

    public void ForLoop()
    {
        Console.WriteLine("Hermed tallene 1-10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }

}
