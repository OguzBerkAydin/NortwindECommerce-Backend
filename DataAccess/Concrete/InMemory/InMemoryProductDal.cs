using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryProductDal : IProductDal
	{
		List<Product> _products;
        public InMemoryProductDal()
        {
			_products = new List<Product>
			{
				new Product{ProductId = 1, CategoryId = 1, ProductName="bardak", UnitPrice=10, UnitsInStock=45},
				new Product{ProductId = 2, CategoryId = 2, ProductName="kalem", UnitPrice=70, UnitsInStock=52},
				new Product{ProductId = 3, CategoryId = 3, ProductName="bilgisayar", UnitPrice=10, UnitsInStock=48},
				new Product{ProductId = 4, CategoryId = 4, ProductName="masa", UnitPrice=150, UnitsInStock=4},
				new Product{ProductId = 5, CategoryId = 5, ProductName="defter", UnitPrice=160, UnitsInStock=5},
			};
        }
        public void Add(Product product)
		{
			_products.Add(product);
		}

		public void Delete(Product product)
		{
			Product productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
			_products.Remove(productToDelete);
		}

		public Product Get(Expression<Func<Product, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetAll()
		{
			return _products;
		}

		public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetAllByCategory(int categoryId)
		{
			return _products.Where(p => p.CategoryId == categoryId).ToList();
		}

		public void Update(Product product)
		{
			Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
			productToUpdate.ProductName = product.ProductName;
			productToUpdate.UnitPrice = product.UnitPrice;
			productToUpdate.UnitsInStock = product.UnitsInStock;
			productToUpdate.CategoryId = product.CategoryId;
		}
	}
}
