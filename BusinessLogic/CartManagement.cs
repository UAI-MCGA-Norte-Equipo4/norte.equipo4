using Common.Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Implementations;
using System;
using BusinessLogic.Contracts;

namespace BusinessLogic
{
	public class CartManagement : ICartManagement
	{
		BaseDataService<Cart> db;

		BaseDataService<CartItem> dbCartItem;
		public UserManagement UserManagement { get; set; }

		public CartManagement()
		{
			db = new BaseDataService<Cart>();
			dbCartItem = new BaseDataService<CartItem>();
			UserManagement = new UserManagement();
		}

		public Cart Get(string name)
		{
			var user = UserManagement.Get(name);

			var cart = db.Get(x => x.Cookie == name).FirstOrDefault();

			if (cart == null)
				cart = db.Create(new Cart() { CartDate= DateTime.Now, CreatedBy = name, CreatedOn = DateTime.Now,  Cookie = name, ChangedBy= name, ChangedOn = DateTime.Now});

			return cart;
		}

		public void AddItem(CartItem item)
		{
			if(dbCartItem.Get(x => x.CartId == item.CartId && x.ProductId == item.ProductId).FirstOrDefault() == null)
				dbCartItem.Create(item);

		}

		public CartItem GetItem(int id)
		{
			return dbCartItem.Get(x => x.Id == id).FirstOrDefault();
		}

		public void UpdateItem(CartItem item)
		{
			dbCartItem.Update(item);
		}

		public void RemoveItem(CartItem item)
		{
			dbCartItem.Delete(item);
		}

        public void Remove(int id)
        {
            db.Delete(id);
        }
    }
}
