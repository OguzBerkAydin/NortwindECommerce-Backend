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
	public class OrderManager : IOrderService
	{
		private readonly IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public IResult Add(Order entity)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Order entity)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Order> Get(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Order>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IResult Update(Order entity)
		{
			throw new NotImplementedException();
		}
	}
}
