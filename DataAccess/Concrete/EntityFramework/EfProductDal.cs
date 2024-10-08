﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
	{
		public List<ProductDetailDto> GetProductDetails()
		{
			using (NorthwindContext context = new())
			{
				var results = from p in context.Products
							  join c in context.Categories
							  on p.CategoryId equals c.CategoryId
							  select new ProductDetailDto
							  {
								  ProductId = p.ProductId,
								  ProductName = p.ProductName,
								  CategoryName = c.CategoryName,
								  UnitPrice = p.UnitPrice,
								  UnitsInStock = p.UnitsInStock,
							  };
				return results.ToList();
			}
		}
	}
}
