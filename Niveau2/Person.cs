using System;

namespace Niveau2;

public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void PrintInfo(){
        System.Console.WriteLine($"{name} er {age} år.");
    }

}
