using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Contracts;
using Common.Entities;
using DataAccess.Implementations;

namespace BusinessLogic
{
	public class OrderManagement : IOrderManagement
	{

		BaseDataService<Order> db;

		BaseDataService<OrderNumber> dbOrderNumber;
		public UserManagement UserManagement { get; set; }

		public OrderManagement()
		{
			db = new BaseDataService<Order>();
			dbOrderNumber = new BaseDataService<OrderNumber>();
			UserManagement = new UserManagement();
		}

		public void AddOrder(Order order)
		{
			db.Create(order);
		}

		public Order Get(string name)
		{
			throw new NotImplementedException();
		}

		public Order GetItem(int id)
		{
			return db.GetById(id);
		}

		public void UpdateItem(Order item)
		{
			throw new NotImplementedException();
		}

		public OrderNumber AddOrderNumber(OrderNumber number)
		{
			dbOrderNumber.Create(number);
			return number;
		}

		public IList<Order> GetAll()
		{
			return db.Get().ToList();
		}
		public IList<OrderNumber> GetAllOrderNumber()
		{
			List<OrderNumber> ListOrderNumber = new List<OrderNumber>();
			ListOrderNumber = dbOrderNumber.Get();
			return ListOrderNumber;

		}
	}
}
