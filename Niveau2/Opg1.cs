using System;

namespace Niveau2;

public class Opg1
{
    private List<int> numberList = new()
    {
        34,
        5454,
        146,
        9,
        52
    };

    private int AddNumbers(List<int> numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public void DoMath()
    {
        System.Console.WriteLine($"summen af tallene i listen ({string.Join(", ", numberList)}) er {AddNumbers(numberList)}");
    }
}
