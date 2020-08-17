using System.Collections.Generic;
using Common.Entities;

namespace BusinessLogic.Contracts
{
	public interface IOrderManagement
	{
		Order Get(string name);
		void AddOrder(Order order);
		Order GetItem(int id);
		IList<Order> GetAll();
		void UpdateItem(Order item);
		OrderNumber AddOrderNumber(OrderNumber number);
		IList<OrderNumber> GetAllOrderNumber();

	}
}
