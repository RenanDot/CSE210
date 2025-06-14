using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Online Ordering System!\n");

        Customer customer1 = new Customer("Renan Daniel de Campos", new Address("Rua Eng. Edson Luis Patekoski, 132", "Cosmópolis", "SP", "Brazil"));
        Customer customer2 = new Customer("Carter Borget", new Address("123 Main St", "Springfield", "IL", "USA"));

        Product product1 = new Product("Nike Air Max", "P001", 120.00m, 1);
        Product product2 = new Product("Nike Shirt Black", "N002", 30.00m, 3);
        Product product3 = new Product("Nike Socks", "S005", 5.00m, 2);
        Product product4 = new Product("Adidas Ultraboost", "P002", 150.00m, 1);
        Product product5 = new Product("Adidas Shirt White", "N003", 25.00m, 2);
        Product product6 = new Product("Adidas Socks", "S006", 7.00m, 3);
        Product product7 = new Product("Puma Running Shoes", "P003", 100.00m, 1);
        Product product8 = new Product("Puma Hoodie", "N004", 60.00m, 1);

        Order order1 = new Order(customer1, new List<Product> { product1, product2, product3, product8 });
        Order order2 = new Order(customer2, new List<Product> { product4, product5, product6, product7 });

        Console.WriteLine("Order 1:\n");
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice():C}\n");
        
        Console.WriteLine("---------------------------------------------------\n");

        Console.WriteLine("Order 2:\n");
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice():C}\n");

    }
}