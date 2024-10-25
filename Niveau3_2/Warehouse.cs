using System;

namespace Niveau3_2;

public class Warehouse
{
    private List<Product> products = new();

    public void CreateProduct(Product product)
    {
        products.Add(product);

        System.Console.WriteLine("Product added!\n");
        PrintProducts();
    }

    public void DeleteProduct(Product product)
    {
        int id = product.Id;
        products.Remove(products.First(p => p.Id == id));

        System.Console.WriteLine($"Product #{id} removed!\n");
        PrintProducts();
    }

    public void DeleteProduct(int id)
    {
        products.Remove(products.First(p => p.Id == id));

        System.Console.WriteLine($"Product #{id} removed!\n");
        PrintProducts();
    }

    public void PrintProducts()
    {
        System.Console.WriteLine("PRODUCTS:");
        foreach (Product product in products)
        {
            System.Console.WriteLine($"\t{product.Id}, {product.Name}");
        }
        System.Console.WriteLine("");
    }
}
