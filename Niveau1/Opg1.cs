namespace Niveau1;

class Opg1
{
    private int integer = 38;
    private float floatingPoint = 56.7F;
    private string stringValue = "Hej, jeg er en banan!";
    private bool isTrue = false;

    public void PrintValues()
    {
        Console.WriteLine(integer.ToString());
        Console.WriteLine(floatingPoint.ToString());
        Console.WriteLine(stringValue);
        Console.WriteLine(isTrue.ToString());
    }
}