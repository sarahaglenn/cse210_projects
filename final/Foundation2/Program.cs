using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address add1 = new Address("468 Main St", "Dallas", "TX", "US");
        Customer cust1 = new Customer("Holly Garrison", add1);

        Address add2 = new Address("13902 Meadowbrook Dr", "Denver", "CO", "USA");
        Customer cust2 = new Customer("Celeste McKenzie", add2);

        Address add3 = new Address("17 Nytgatan", "Banff", "Ontario", "Canada");
        Customer cust3 = new Customer("Laurel Dalton", add3);

        List<Product> order1Products =
            [
            new Product("Silver Plated Dinner Fork", "SF34", 12.99, 8),
            new Product("Green Dessert Plate", "DPG78", 24.50, 8),
            new Product("Lilac Lilly Tablecloth - 24 x 36", "LLT2436", 45.89, 1)
            ];
        List<Product> order2Products = 
            [
            new Product("White Ceramic Coated Mug", "WCM64", 10.89, 12),
            new Product("Lilac Lilly Tablecloth - 24 x 36", "LLT2436", 45.89, 2)
            ];
        List<Product> order3Products = 
            [
            new Product("Stainless Steel Soup Spoon", "SS43", 7.49, 3),
            new Product("White Ceramic Coated Soup Bowl", "WCB988", 23.99, 4),
            new Product("Silver Plated Dinner Fork", "SF34", 12.99, 8),
            new Product("Wooden Napkin Ring", "WNR25", 3.99, 8)
            ];

        Order order1 = new Order(cust1, order1Products);
        Order order2 = new Order(cust2, order2Products);
        Order order3 = new Order(cust3, order3Products);    

        List<Order> orders = [order1, order2, order3];
        foreach (Order o in orders)
        {
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${o.ComputeTotalCost()}");
        }   
    }
}