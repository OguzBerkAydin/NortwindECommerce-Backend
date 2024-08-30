using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCategoryDal : ICategoryDal
	{
		public void Add(Category entity)
		{
			using (NorthwindContext context = new())
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(Category entity)
		{
			using (NorthwindContext context = new())
			{
				var deletedEntity = context.Entry(entity);
				deletedEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public Category Get(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
