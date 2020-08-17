using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Entities;
using BusinessLogic;
using BusinessLogic.Contracts;

namespace ArtMarket.Controllers
{
	public class OrderController : BaseController
	{
		public ICartManagement Management { get; set; }
		public IOrderManagement OrderManagement { get; set; }
		public IUserManagement UserManagement { get; set; }

		public IProductManagement ProductManagement { get; set; }

		public OrderController()
		{
			Management = new CartManagement();
			OrderManagement = new OrderManagement();
			UserManagement = new UserManagement();
			ProductManagement = new ProductManagement();
		}

		// GET: Order
		public ActionResult Index()
		{
			return View(OrderManagement.GetAll().OrderByDescending(x => x.Id).ToList());
		}

		public ActionResult Details(int id)
		{
			return View(OrderManagement.GetItem(id).OrderItems.ToList());
		}

		public ActionResult Payment()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Checkout(FormCollection form)
		{
			var useremail = TryGetUserId();
			var cart = Management.Get(useremail);
			var user = UserManagement.Get(useremail);

			Order order = new Order();
			OrderNumber Onumber = new OrderNumber();
			CheckAuditPattern(order, true);
			CheckAuditPattern(Onumber, true);

			var ListOnumbers = OrderManagement.GetAllOrderNumber();

			var od = ListOnumbers.OrderByDescending(p => p.Id)
								 .FirstOrDefault();

			if (od == null)
			{
				Onumber.Number = 0001;
			}
			else
			{
				Onumber.Number = 000 + (od.Id + 1);
			}

			order.OrderDate = DateTime.Now;
			order.ItemCount = cart.CartItems.Count();
			order.TotalPrice = Convert.ToDouble(cart.CartItems.Sum(item => item.Price));
			order.UserId = user.Id;

			//CheckAuditPattern(order.OrderItems, true);

			order.OrderItems = cart.CartItems.Select(x => new OrderDetail()
			{
				ProductId = x.ProductId,
				Price = x.Price,
				Quantity = x.Quantity,
				CreatedOn = DateTime.Now,
				ChangedOn = DateTime.Now
			}).ToList();


			try
			{
				Management.Remove(cart.Id); //LIMPIA EL CARRITO
				OrderManagement.AddOrderNumber(Onumber);
				order.OrderNumber = Onumber.Id;
				OrderManagement.AddOrder(order); //AGREGA LA ORDEN

				foreach (var item in order.OrderItems)
				{
					var prod = ProductManagement.Get(item.ProductId);
					prod.QuantitySold += item.Quantity;
					ProductManagement.Update(prod);
				}
				
			}
			catch (Exception e)
			{
				ExceptionContext ex = new ExceptionContext();
				ex.Exception = e.InnerException;
				OnException(ex);
			}

			return View(order);
		}
	}
}