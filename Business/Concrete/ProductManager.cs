using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
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
		ICategoryService _categoryService;

		public ProductManager(IProductDal productDal, ICategoryService categoryService)
		{
			_productDal = productDal;
			_categoryService = categoryService;
		}
		public List<ProductDetailDto> GetProductDetails()
		{
			return _productDal.GetProductDetails();
		}


		[SecuredOperation("product.add,admin")]
		[ValidationAspect(typeof(ProductValidator))]
		[CacheRemoveAspect(".*Product.*Get.*")]
		public IResult Add(Product product)
		{
			IResult result = BusinessRules.Run(CheckIfProductCountOfCategoryCorrect(product.CategoryId),
				CheckIfProductNameExist(product.ProductName));

			if (result != null)
			{
				return result;
				
			}
			_productDal.Add(product);

			return new SuccessResult(MyMessages.ProductAdded);
		}

		[CacheAspect]
		public IDataResult<List<Product>> GetAll()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler Listelendi");
		}

		[CacheAspect]
		public IDataResult<Product> Get(int id)
		{
			return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
		}

		public IResult Update(Product entity)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Product entity)
		{
			throw new NotImplementedException();
		}


		public IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
		{
			var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
			if (result > 10)
			{
				return new ErrorResult(MyMessages.ProductCountOfCategoryError);
			}
			return new SuccessResult();
		}

		public IResult CheckIfProductNameExist(string name)
		{
			var result = _productDal.GetAll(p => p.ProductName == name).Any();

			if (result)
			{
				return new ErrorResult(MyMessages.ProductNameAldreadyExist);
			}
			return new SuccessResult();
		}

		public IResult CheckIfCategoryLimitExceeded(int categoryId)
		{
			var result = _categoryService.GetAll();
			if(result.Data.Count > 15)
			{
				return new ErrorResult(MyMessages.CategoryLimitExceded);
			}
			return new SuccessResult();
		}
	}
}
