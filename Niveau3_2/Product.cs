using System;

namespace Niveau3_2;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
}
