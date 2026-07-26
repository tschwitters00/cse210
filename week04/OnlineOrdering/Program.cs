using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("5786 One Way Dr", "Austin","Texas","USA");
        Address address2 = new Address("123 Round Street", "Montreal","Quebec","Canada");
        Address address3 = new Address("9 Street Ave", "Provo","Utah","USA");

        Customer customer1 = new Customer("Jim Bob", address1);
        Customer customer2 = new Customer("Peter Parker", address2);
        Customer customer3 = new Customer("Samuel Kim", address3);

        List<Product> products1 = 
        [
            new Product("Apples", "APS", 2.25, 10),
            new Product("Chocolate Milk", "CMK", 5, 2),
            new Product("Dr.Pepper", "DRP", 9.43, 1),  
        ];
        List<Product> products2 = 
        [
            new Product("Hamburger", "BRG", 7, 20),
            new Product("Hamburger Buns", "HBN", 4, 20),
            new Product("Ketchup", "KTP", 5, 4),  
        ];
        List<Product> products3 = 
        [
            new Product("Twix", "TWX", 1.75, 3),
            new Product("Peanut Butter", "PNB", 8.25, 2),
            new Product("Watermelon", "WTM", 11.24, 5),  
        ];

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);
        Order order3 = new Order(products3, customer3);

        void PrintOrder(Order order)
        {
            Console.WriteLine($"\nTotal: ${order.CalculateTotalPrice()}\n\n{order.GetPackingLabel()}\n{order.GetShippingLabel()}\n");
        }
        
        PrintOrder(order1);
        PrintOrder(order2);
        PrintOrder(order3);
    }
}