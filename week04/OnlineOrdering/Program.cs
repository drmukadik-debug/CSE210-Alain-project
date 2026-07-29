using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1(USA)

        Address address1 = new Address("18 Steven Street","Dallas","Texas", "USA");

        Customer customer1 = new Customer("Allan Walker", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P456", 1200.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P458", 15.35, 3));
        order1.AddProduct(new Product("Printer", "P459", 250.12, 1));

        // Order 2(Outside USA)

        Address address2 = new Address("13 Prison Street","Mbujimayi","Kasai-East", "DR Congo");

        Customer customer2 = new Customer("Arthur Kabeya", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Ipad", "P460", 250.40, 2));
        order2.AddProduct(new Product("Smartphone", "P463", 950.75, 2));
        order2.AddProduct(new Product("Charger", "P465", 16.50, 4));

        // Display Order 1

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("             ORDER 1");
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());
        
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTOTAL PRICE: ${order1.CalculateTotalCost():F2}");

        // Display Order 2

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("             ORDER 2");
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());
        
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTOTAL PRICE: ${order2.CalculateTotalCost():F2}");


    }
}