using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class ProductManager : IProductService
	{
		IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}
		public List<ProductDetailDto> GetProductDetails()
		{
			return _productDal.GetProductDetails();
		}
		public IResult Add(Product product)
		{
			_productDal.Add(product);
			return new Result(true, "Ürün eklendi");
		}

		public DataResult<List<Product>> GetAll()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"Ürünler Listelendi");
		}

		public DataResult<Product> Get(int id)
		{
			throw new NotImplementedException();
		}

		Result IGenericService<Product>.Add(Product entity)
		{
			throw new NotImplementedException();
		}

		public Result Update(Product entity)
		{
			throw new NotImplementedException();
		}

		public Result Delete(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
