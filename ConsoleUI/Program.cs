using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ProductManager productManager = new(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine();
            Console.WriteLine("Hello, World!");
		}
	}
}
