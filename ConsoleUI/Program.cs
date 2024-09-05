using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ProductTest();

			//CategoryTest();

			ProductManager productManager = new(new EfProductDal());
			var results = productManager.GetProductDetails();

			if (results.Success)
			{
				foreach (var p in results.Data)
				{
					Console.WriteLine(p.ProductName + "***" + p.CategoryName);
				}
                Console.WriteLine(results.Message);
            }
			else { Console.WriteLine(results.Message); }

		}

		private static void CategoryTest()
		{
			CategoryManager categoryManager = new(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new(new EfProductDal());

			foreach (var product in productManager.GetAll().Data)
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
