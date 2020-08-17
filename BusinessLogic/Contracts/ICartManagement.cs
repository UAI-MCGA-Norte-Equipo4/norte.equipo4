using Common.Entities;

namespace BusinessLogic.Contracts
{
	public interface ICartManagement
	{
		Cart Get(string name);

		void AddItem(CartItem item);
		CartItem GetItem(int id);
		void UpdateItem(CartItem item);
        void Remove(int id);
	}
}