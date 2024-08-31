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
            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine(p.ProductName + "***" + p.CategoryName);
            }

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

			foreach (var product in productManager.GetAll())
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
