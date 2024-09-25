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

		public IDataResult<List<Product>> GetAll()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"Ürünler Listelendi");
		}

		public IDataResult<Product> Get(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Product entity)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
