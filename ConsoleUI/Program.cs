﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ProductTest();

			CategoryManager categoryManager = new(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}

		}

		private static void ProductTest()
		{
			ProductManager productManager = new(new EfProductDal());

			foreach (var product in productManager.GetAll())
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
