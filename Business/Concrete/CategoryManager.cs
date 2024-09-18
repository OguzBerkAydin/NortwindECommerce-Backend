using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public Result Add(Category entity)
		{
			throw new NotImplementedException();
		}

		public Result Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public DataResult<Category> Get(int id)
		{
			throw new NotImplementedException();
		}

		public DataResult<List<Category>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Result Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
