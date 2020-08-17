using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComprasOnline.Controllers
{
	public class HomeController : Controller
	{
		public IProductManagement ProductManagement { get; set; }

		public HomeController()
		{
			ProductManagement = new ProductManagement();
		}

		public ActionResult Index()
		{
			var products = ProductManagement.GetAllProducts().OrderByDescending(x => x.CreatedBy).Take(3);
			return View(products.ToList());
		}

		public ActionResult Example()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}
	}
}