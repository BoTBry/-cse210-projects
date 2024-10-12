using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
		private string name;
		private string productID;
		private float price;
		private int quantity;

		public Product(string name, string productID, float price, int quantity)
		{
				this.name = name;
				this.productID = productID;
				this.price = price;
				this.quantity = quantity;
		}

		public string Name => name;
		public string ProductID => productID;
		public float Price => price;
		public int Quantity => quantity;

		public float GetTotalCost()
		{
				return price * quantity;
		}
}
