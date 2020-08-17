using ArtMarket.Controllers;
using BusinessLogic;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComprasOnline.Controllers
{
	[Authorize]
	public class CartController : BaseController
	{
		public CartManagement Management { get; set; }

		public ProductManagement ProductManagement { get; set; }
		// GET: Cart

		public CartController()
		{
			Management = new CartManagement();
			ProductManagement = new ProductManagement();
		}

		public ActionResult Index(Cart cart = null)
		{
			if (cart == null)
			{
				var user = TryGetUserId();
				cart = Management.Get(user);
			}
			
			return View("Index", cart);
		}

		public ActionResult Add(int id)
		{
			var user = TryGetUserId();
			var cart = Management.Get(user);

			var prod = ProductManagement.Get(id);

			var item = new CartItem() { CartId = cart.Id, ProductId = prod.Id, Price = prod.Price, Quantity = 1 };

			CheckAuditPattern(item, true);

			Management.AddItem(item);

			if (!cart.CartItems.Any(x => x.ProductId == item.ProductId))
			{
				item.Product = prod;
				cart.CartItems.Add(item); 
			}

			return Index(cart);
		}

		public ActionResult Increase(int id)
		{
			var item = Management.GetItem(id);
			item.Quantity++;
			item.Price = item.Product.Price * item.Quantity;
			CheckAuditPattern(item, false);

			Management.UpdateItem(item);

			return Index();
		}

		public ActionResult Decrease(int id)
		{
			var item = Management.GetItem(id);

			if (item.Quantity > 1)
			{
				item.Quantity--;
				item.Price = item.Product.Price * item.Quantity;
				CheckAuditPattern(item, false);

				Management.UpdateItem(item);
			}

			return Index();
		}

		public ActionResult Delete(int id)
		{
			var item = Management.GetItem(id);
			Management.RemoveItem(item);

			return Index();
		}
    }
}