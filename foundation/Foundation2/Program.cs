using System;
using System.Collections.Generic;
using System.Text;

class Program
{
		static void Main(string[] args)
		{
				Address address = new Address("123 Main St", "Springfield", "IL", "USA");
				Customer customer = new Customer("John Doe", address);

				Order order = new Order(customer);

				Product product1 = new Product("Laptop", "L001", 999.99f, 1);
				Product product2 = new Product("Mouse", "M001", 19.99f, 2);

				order.AddProduct(product1);
				order.AddProduct(product2);

				Console.WriteLine(order.GetPackingLabel());
				Console.WriteLine(order.GetShippingLabel());
				Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
		}
}