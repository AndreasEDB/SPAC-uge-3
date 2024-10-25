using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Niveau3;

public class Opg1
{
    List<string> names = new();

    public void ReadNames()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string projectRoot = Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\.."));
        string filePath = Path.Combine(projectRoot, "names.json");

        using StreamReader reader = new(filePath);
        var json = reader.ReadToEnd();
        var jsonNames = JArray.Parse(json);

        foreach (string? name in jsonNames)
        {
            if (name == null) continue;

            names.Add(name);
        }
    }

    public void SortNames()
    {
        names.Sort(StringComparer.InvariantCulture);
    }

    public void PrintNames()
    {
        foreach (string name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}
