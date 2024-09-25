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

		public IResult Add(Category entity)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Category> Get(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Category>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IResult Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
