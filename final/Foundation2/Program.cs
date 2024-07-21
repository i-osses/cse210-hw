using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        Product product1 = new Product("Laptop", "P001", 800.00, 1);
        Product product2 = new Product("Mouse", "P002", 20.00, 2);
        Product product3 = new Product("Keyboard", "P003", 50.00, 1);

        Address address1 = new Address("123 Love St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("321 Riverside St", "Toronto", "ON", "Canada");


        Customer customer1 = new Customer("James Osses", address1);
        Customer customer2 = new Customer("Emily Rosemary", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Creating a list of orders
        List<Order> orders = new List<Order> { order1, order2 };

        // Displaying order details using foreach loop
        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"----------------------");
            Console.WriteLine($"    Order {orderNumber}:");
            Console.WriteLine($"{order.GetPackingLabel()}");
            Console.WriteLine($"{order.GetShippingLabel()}");
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
            orderNumber++;
        }


    }
}