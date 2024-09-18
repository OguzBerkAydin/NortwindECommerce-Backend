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

		public Result Add(Order entity)
		{
			throw new NotImplementedException();
		}

		public Result Delete(Order entity)
		{
			throw new NotImplementedException();
		}

		public DataResult<Order> Get(int id)
		{
			throw new NotImplementedException();
		}

		public DataResult<List<Order>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Result Update(Order entity)
		{
			throw new NotImplementedException();
		}
	}
}
