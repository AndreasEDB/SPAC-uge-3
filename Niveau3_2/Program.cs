namespace Niveau3_2;

public class Program
{    static void Main(string[] args)
    {
        Warehouse warehouse = new();

        Product product = new()
        {
            Id = 1,
            Name = "Dinkelhopper",
            Price = 120.75F,
            Stock = 15
        };

        Product product2 = new()
        {
            Id = 2,
            Name = "Dingenot",
            Price = 199.99F,
            Stock = 377
        };

        Product product3 = new()
        {
            Id = 3,
            Name = "Himstregims",
            Price = 650.00F,
            Stock = 6
        };

        Product productToDelete = new()
        {
            Id = 1,
            Name = "Dinkelhopper",
            Price = 120.75F,
            Stock = 15
        };

        warehouse.CreateProduct(product);
        warehouse.CreateProduct(product2);
        warehouse.CreateProduct(product3);
        warehouse.DeleteProduct(productToDelete);
    }
}