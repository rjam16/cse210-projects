using System;
using System.Net.Http.Headers;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("9542 Morris Street", "Anaheim", "CA 92801", "USA");
        Customer c1 = new Customer("John Carlson", a1);
        List<Product> productList1 = new List<Product>();
        Product p1001 = new Product("Graphing Calculator", "GC200", 65.99, 1);
        Product p1002 = new Product("Notebook", "NB50", 3.50, 5);
        Product p1003 = new Product("Mechanical Pencil", "MP05", 1.99, 10);
        productList1.Add(p1001);
        productList1.Add(p1002);
        productList1.Add(p1003);
        Order o1 = new Order(productList1, c1);
        Console.WriteLine("Order Number: 1");
        o1.DisplayResults();
        Console.WriteLine();
        Address a2 = new Address("799 Arnulfo Station", "VonMouth", "AL 47414-0616", "AUS");
        Customer c2 = new Customer("Susan Banks", a2);
        List<Product> productList2 = new List<Product>();
        Product p2001 = new Product("Highlighter Set", "HLSET", 4.99, 3);
        Product p2002 = new Product("Index Cards", "IC100", 1.75, 2);
        Product p2003 = new Product("Scientific Calculator", "SCC1000", 12.50, 1);
        productList2.Add(p2001);
        productList2.Add(p2002);
        productList2.Add(p2003);
        Order o2 = new Order(productList2, c2);
        Console.WriteLine("Order Number: 2");
        o2.DisplayResults();
        Console.WriteLine();
        Address a3 = new Address("563 Pin Oak St.", "Oakland", "CA 94601", "USA");
        Customer c3 = new Customer("Timothy Smith", a3);
        List<Product> productList3 = new List<Product>();
        Product p3001 = new Product("Pencil Case", "PC100", 8.99, 2);
        Product p3002 = new Product("Highlighter Set", "HLSET", 4.99, 4);
        productList3.Add(p3001);
        productList3.Add(p3002);
        Order o3 = new Order(productList3, c3);
        Console.WriteLine("Order Number: 3");
        o3.DisplayResults();
        Console.WriteLine();

    }
}